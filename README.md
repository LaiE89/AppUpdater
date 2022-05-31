# App Updater
Allows users to update an app if a new version is available on an online file server (e.g. Dropbox).
Works for Windows only.

## Usage
### Uploading your files
Zip your executable files for your app -> Create a 'version.txt' file and in the file, type in your version number -> Upload both files to any online file server like Dropbox -> Copy the link of both files. You are going to need these links for the customizing process. 
![image](https://user-images.githubusercontent.com/97263413/170921964-edcb67f3-987b-4cc1-b279-7a5829aedb14.png)

### Installation and Customization
Download the folder -> open 'MainWindow.xaml.cs' -> Change the 'specificFolder' variable to a path you want your data files to be in -> change the 'configInfo' dictionary according to the comments -> save and open 'AppUpdaterUtility.sln' in Visual Studio (with .NET Core installed) -> change the properties of the project to change icon of app, name of app, etc. -> publish the project (should result in a .exe file and pdb file) -> Distribute the '.exe' file to others 

### Updating your files
Once you updated the executable files for your app: Update the version number in the 'version.txt' file -> Update both files in your online file server (Make sure the updated files have the same link as the old files)

Now when anyone runs the distributed '.exe' file, it will prompt an update and begin updating their app locally.
