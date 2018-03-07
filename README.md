# Introduction 
The Mixed Reality Starter Kit was created as a reusable template for quickly publishing apps that display interactive 3D holograms to Microsoft's HoloLens with little to no programming or scripting knowledge. The kit includes basic visual buttons, hand gestures, and voice commands for model rotation, resizing, hiding portions of a model, and undoing these actions.


# Getting Started
1.	Installation process
	1. Clone or download this repository from GitHub.
	1. Clone or download Microsoft's Mixed Reality Toolkit from https://github.com/Microsoft/MixedRealityToolkit-Unity
	1. Open Unity and create a new project:
		1. Ensure that the 3D option is selected next to the project's name.
		1. Tip: Keep folder paths and project names short and do not include spaces in your project's name. Unity struggles with long file paths and file names as well as spaces in those paths.
		1. Example Project Name: MRStarterKitDemo
		1. Example Location: c:\u\ 
	1. Unity will create a folder based on your project name and build a folder structure and standard files for your new project inside the project's folder.
		1. For the example project name and location above, the folder hierarchy will look like this:
    ```
	C:\u\MRStarterKitDemo\
    ├───Assets
    ├───Library
    ├───ProjectSettings
    ├───Temp
    ├───UnityPackageManager
    MRStarterKitDemo.sln
    ```
	3. Use Windows Explorer to copy the HoloToolkit folder from the Microsoft Mixed Reality Toolkit's Assets folder:
		1. In Windows Explorer, navigate to the exteracted location of Microsoft's Mixed Reality Toolkit.
		1. Open the Assets folder at the root of the Mixed Reality Toolkit folder hierarchy.
		1. Copy the HoloToolkit folder.
		1. Navigate to the the location of your new Unity project.
		1. Double-click on the project's folder.
		1. Double-click on the Assets folder inside the project's folder.
		1. Paste the copied HoloToolkit folder into the project's Assets folder.
		1. Unity will process the copied files, making them available for use in your project.
	3. Use Windows Explorer to copy the contents of this git repo's Assets folder to your new project's Assets folder:
		1. In Windows Explorer, navigate to the extracted location of this git repo.
		1. Open the Assets folder at the root of the MRStarterKitDemo folder hierarchy.
		1. Copy all of the contents of the Assets folder.
		1. Navigate to the location of your new Unity project.
		1. Double-click on the project's folder.
		1. Double-click on the Assets folder inside the project's folder.
		1. Paste the copied files into the project's Assets folder.
		1. Unity will process the copied files, making them available for use in your project.
	4. Your Unity project and assets are now ready to build and test.
	
1.	Software dependencies
    1. Microsoft Windows 10 with Fall Creator's Update installed. You can get a free virtual development environment from Microsoft here: https://developer.microsoft.com/en-us/windows/downloads/virtual-machines
    1. Unity 3D 2017.2.0f3, available here (use the "**Unity 2017.2.0   12 Oct, 2017**" download link): https://unity3d.com/get-unity/download/archive 
    1. Visual Studio 2017 15.4 or higher: https://www.visualstudio.com/downloads/
	1. Microsoft Mixed Reality Toolkit, available here: https://github.com/Microsoft/MixedRealityToolkit-Unity


# Build and Test
1. In Unity, open the sample scene, MRStarterKitDemoScene.unity:
	1. Click File -> Open Scene
	1. Navigate to Assets/Scenes/MRStarterKitDemoScene.unity
	1. Double click on MRStarterKitDemoScene.unity to open the scene.
	1. Unity will load the sample scene. 
1. Look at Unity's Hierarchy panel (usually located on the left side of the screen in Unity). You should see several objects listed in the heirarchy, which can be expanded to show child objects by clicking the triangles next to each item in the list:
	1. MixedRealityCameraParent - A collection of objects and scripts from Microsoft's MixedRealityToolkit that detect where the user is gazing while wearing the HoloLens. 
	1. InputManager - A collection of objects and scripts from Microsoft's MixedRealityToolkit that handle gesture-based inputs, spatial mapping, and other events that fire while a HoloLens app is running.
	1. Cursor - A collection of objects and scripts from Microsoft's MixedRealityToolkit that control the display of the in-app cursor.
	1. SceneContents - A collection of objects and scripts that make up the Mixed Reality Starter Kit, including the visual user interface and our sample 3D model. 
		1. UI - A collection of objects and scripts that render a visible user interface the user will see when using the app.
			1. UIControlsDefault: By default these controls are visible in the scene when the app launches.
				- MRStarterKitLabel: The title area and text that appear above the visible UI controls in the scene.
				- ButtonShowVoiceCommands: When the user taps this button, the VoiceCommandDetails collection of objects (described below) becomes visible.
				- ButtonShowDetailedControls: Tapping this button makes the UIControlsDetailed (described below) visible.
			1. UIControlsDetailed: By default, these controls are hidden from view when the app launches and are made visible when the user taps ButtonShowDetaieldControls. 
				- ButtonHideDetailedControls: Tapping this button hides the UIControlsDetailed colelction of buttons.
				- ButtonUp: Tapping this button rotates the model 10 degrees on its horizontal axis.
				- ButtonDown: Tapping this button rotates the model 10 degrees on its horizontal axis in the opposite direction of ButtonUp.
				- ButtonLeft: Tapping this button rotates the model 10 degrees counter-clockwise on its vertical axis.
				- ButtonRight: Tapping this button rotates the model 10 degrees clockwise on its vertical axis.
				- ButtonLarge: Tapping this button enlarges the model by 10%.
				- ButtonSmall: Tapping this button reduces the size of the model by 10%.
				- ButtonReset: Tapping this button unhides all parts of the model (mesh groups) that were hidden by the user.
				- ButtonUndoHide: Tapping this button unhides the last-hidden part of the model. If multiple parts of the model are hidden, the user can tap this button repeatedly to bring back hidden parts of the model one at a time until everything that had been hidden is visible again.
			1. VoiceCommandDetails: A collection of objects that render a modal dialog to the screen that displays available voice commands for the app. Hidden by default, this collection is made visible when the user taps ButtonShowVoiceCommands
				- Background: Object that forms the background of the VoiceCommandDetails modal dialog.
				- Text: Contains the text displayed in VoiceCommandDetails.
				- ButtonCloseVoiceCommandDetails: Tapping this button near the bottom of the modal dialog hides the VoiceCommandDetails collection.
				- ButtonXCloseVoiceCommandDetails: Tapping this button in the top right corner of the modal dialog hides the VoiceCommandDetails collection.
		1. SampleModel: The sample 3D model which contains many mesh groups.
			- mmGroup0: One of the mesh groups that makes up the SampleModel. Scripts from the MR Starter Kit are applied to select mesh groups to facilitate interaction.
			- mmGroup1
			- ... (multiple mmGroup items)
			- mmGroup6
1. In Unity, click the Mixed Reality Toolkit menu at the top of the screen and select Configre -> Apply Mixed Reality Project Settings
1. The Apply Mixed Reality Settings window will open. Ensure the following checkboxes are checked:
	1. Target Windows Universal UWP
	1. Enable XR
	1. Build for Direct3D
	1. Enable .NET scripting backend
1. Click the Apply button to apply these settings to your project. This readies the project to be built into a Visual Studio solution that can then be built and deployed to the HoloLens.
1. Click on Unity's file menu and select Save Project.
1. Click on Unity's file menu and select Save Scenes.
1. Build the Unity Scene into a Visual Studio solution:
	1. In Unity, click on the File menu and select Build Settings...
	1. In the Build Settings window that appears, click the button labeled Add Open Scenes.
	1. Ensure the following fields in the Build Settings window are set properly:
		1. Under Scenes in Build, your scene is listed and the checkbox next to its name is checked.
		1. In the bottom half of the screen, on the left side under Platform, Universal Windows Platform is selected.
		1. In the bottom half of the screen, on the right side under Universal Windows Platform:
			1. Target Device: HoloLens
			1. Build Type: D3D
			1. SDK: Latest Installed
			1. Build and Run On: Local Machine
			1. Copy References: Unchecked
			1. Unity C# Projects: Checked
			1. Development Build: Unchecked
			1. Autoconnect Profiler: Unchecked
			1. Scripts Only Build: Unchecked
			1. Compression Method: None
	1. Click File -> Save Project once more to save any settings you may have adjusted in the previous step. You can keep the Build Settings window open as you do this.
	1. Click the Build button at the bottom of the Build Settings window.
	1. Unity will prompt you to select a folder in which to build the Visual Studio solution. Near the top of the window that appears, click "New folder" and name the folder App.
	1. Click once on the App folder you just created to highlight it, then click Select Folder near the bottom right corner of the window.
	1. A progress bar will appear as Unity builds the Visual Studio solution.
	1. Once the build completes, Windows Explorer will pop up a new window showning you the contents of your project's folder. If Windows Explorer does not automatically pop up a window, use Windows Explorer to navigate to your project's folder.
	1. Double-click on the App folder to open it.
	1. Double-click on the Visual Studio solution file (.sln) in the App folder that matches your project name (e.g. MRStarterKitDemo.sln).
	1. Visual Stuido will open the solution file.
	1. Configure the Visual Studio solution to deploy to the HoloLens:
		1. At the top of the screen, adjust the Debug dropdown to read Release.
		1. Adjust the ARM dropdown to read x86.
		1. Adjust the Local Machine dropdown depending on your setup. We suggest a USB connection as in our experience it's faster, more reliable, and you don't need to worry about dynamic IP addresses, which typically change frequently on large Wi-Fi networks.
			1. If your HoloLens is connected to the PC via a USB Cable, select Device.
			1. If you wish to deploy to HoloLens via Wi-Fi, select Remote Connection:
				1. In the window that appears, enter your HoloLens' IP address (Available in HoloLens Settings App -> Netowrk & Internet -> Wi-Fi -> Advanced options)
				1. Authenitcation Mode: Universal (Unencrypted Protocol)
				1. Click Select to save your settings
	1. Build and deploy the solution to HoloLens:
		1. Ensure that the HoloLens is powered on.
		1. Click on the Debug menu and select Start without Debugging or press ctrl-f5.
		1. Visual Studio will build the solution, deploy it to your HoloLens, and attempt to launch the application.
	1. Troubleshooting Build and Deploy issues:
		1. Visual Studio Error: Access is denied
			- Typically, this error indicates that the app did build and deploy successfully, but Visual Studio was unable to launch the app on the HoloLens automatically for some reason. In our experience, as long as Visual Studio's build output window shows build and deploy were successful, you should be able to put on the HoloLens and launch the app.
			- Potential Resolution 1: Uninstall the app from the HoloLens, then use Visual Studio to build and deploy the app again.
			- Potential Resolution 2: Delete the App folder that contains the Visual Studio solution and redo all steps after "Build the Unity Scene into a Visual Studio Solution" above.
		1. Visual Studio Error: Could not deploy while a user-defined section is open
			- We tend to see this error when we are repeatedly building and deploying to HoloLens after making small adjustments to our Unity scene or scripting. If you see this error, your Visual Studio project did not build and deploy to the HoloLens properly.
			- Potential Resolution 1: Clean the Visual Studio solution and try running the app without debugging again. 
			- Potential Resolution 2: Delete the App folder that contains the Visual Studio solution and redo all steps after "Build the Unity Scene into a Visual Studio Solution" above.




# Contribute
1. Raise an Issue: If you would like to make a change in the code base, please log an issue and explain what you are changing/updating/adding and why. 
	- We will have a brief discussion about the change and make a decision based on our combined evaluation of the issue.
2. Create a Pull Request: After you receive a go ahead on the issue, please create a pull request to merge your topic branch into the master branch with issue information in pull request's description.
Once the pull is received, we will evaluate the changes. If pull request is approved, we will merge the code.
We aim to review pull request changes in a week.
Thank you for contributing to MRStarterKit!

If you want to learn more about creating good readme files then refer the following [guidelines](https://www.visualstudio.com/en-us/docs/git/create-a-readme). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)

Working App Demo : 
1. https://www.youtube.com/watch?v=O6x1AsDEqno
2. https://www.youtube.com/watch?v=CEtRWAKekWA
3. https://www.youtube.com/watch?v=0jjTI3yN78w
