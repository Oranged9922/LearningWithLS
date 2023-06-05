# Scripts reads projectNames.txt 
# and generates a .net 7.0 project file for each project name

# the projectNames.txt are in format of:
# 00. **"Project Name"**: Description of the project


import os
import sys
import re
import shutil



def create_projects_and_add_to_sln(projectNames):
    # read project names from projectNames.txt
    # run dotnet new classlib -o <projectName> for each project name
    i = 1
    for projectName in projectNames:
        # create project folder
        # rename projectName to be in format "00_projectName"
        # where 00 is the number of the project (padded to 2 digits)
        projectName = str(i).zfill(2) + "_" + projectName
        # remove spaces
        projectName = projectName.replace(" ", "")
        projectNames[i-1] = projectName
        i += 1
        os.system("dotnet new classlib -n " + projectName + " | dotnet sln add " + projectName + "/" + projectName + ".csproj")



    # rename Class1.cs to Program.cs in each project folder
    for projectName in projectNames:
        # rename Class1.cs to Program.cs
        if os.path.exists(projectName + "/Class1.cs"):
            os.rename(projectName + "/Class1.cs", projectName + "/Program.cs")

            # replace Class1 with Program in Program.cs
            with open(projectName + "/Program.cs", "r") as f:
                content = f.read()
            content = content.replace("Class1", "Program")
            with open(projectName + "/Program.cs", "w") as f:
                f.write(content)

            # replace Class1 with Program in .csproj
            with open(projectName + "/" + projectName + ".csproj", "r") as f:
                content = f.read()
            content = content.replace("Class1", "Program")
            with open(projectName + "/" + projectName + ".csproj", "w") as f:
                f.write(content)

projectNames = []

with open("projectNames.txt", "r") as f:
    for line in f:
        projectNames.append(line.strip())

projectNames = [x for x in projectNames if x != ""]
# split by : and get the first part
projectNames = [x.split(":")[0] for x in projectNames]
# split by . and get the second part
projectNames = [x.split(".")[1] for x in projectNames]
# remove **" and "** from the project names
projectNames = [x.replace("**\"", "").replace("\"**", "") for x in projectNames]

create_projects_and_add_to_sln(projectNames)