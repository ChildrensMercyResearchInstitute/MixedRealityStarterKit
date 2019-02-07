# Introduction 
The Mixed Reality Starter Kit is a reusable collection of C# scripts and Unity prefabricated assets (prefabs) that can be used to quickly develop and publish HoloLens apps that display interactive 3D holograms with little to no programming or scripting knowledge. The kit's user interfaces include visual buttons, hand gestures, and voice commands for model rotation, resizing, hiding, and showing portions of a model.

![mrsk demo](https://user-images.githubusercontent.com/33156643/52087530-51791c80-256f-11e9-83d7-e9d4f5a7478c.gif)

If you're new to Unity and HoloLens, try our **[MixedRealityStarterKitDemo](https://github.com/ChildrensResearchInstitute/MixedRealityStarterKitDemo)** project for Unity 2018, available at the link below. The demo project will familiarize you with the basic workflow of publishing a HoloLens app without going into the details of building a project, scene, and app from scratch.

* https://github.com/ChildrensResearchInstitute/MixedRealityStarterKitDemo


### Working App Demo Videos: 
1. https://www.youtube.com/watch?v=O6x1AsDEqno
2. https://www.youtube.com/watch?v=CEtRWAKekWA
3. https://www.youtube.com/watch?v=0jjTI3yN78w



###	Software Dependencies
1. Microsoft Windows 10 with Fall Creator's Update installed.
1. HoloLens Developer Mode enabled. Read how to enable Developer Mode here: https://docs.microsoft.com/en-us/windows/mixed-reality/using-visual-studio
1. Unity 2018.2.16f1, available here: https://unity3d.com/get-unity/download/archive
	- Developing for HoloLens usually requires a specific version of Unity. We've found Unity 2018.2.16f1, available at the link above, to work best with this project.
	- You can install multiple versions of Unity on your PC by customizing the installation path during the initial install by adjusting the "Unity install folder." We tend to have 2 or 3 versions of Unity installed at any given time, so our standard is to name the install folder after the specific Unity version it will contain. 
	- This screenshot shows a custom install path for Unity 2018.2.16f1:
	
	![unity install path](https://user-images.githubusercontent.com/33156643/52063350-13acd180-2538-11e9-8275-60183ddedefc.PNG)


1. Visual Studio 2017 or higher, available here: https://www.visualstudio.com/downloads/
	 - Select the option to install Universal Windows Platform development tools when prompted by Visual Studio installer.
1. Microsoft Mixed Reality Toolkit for Unity version 2017.4.2.0, available here: https://github.com/Microsoft/MixedRealityToolkit-Unity/archive/2017.4.2.0.zip

### Hardware Requirements
1. Windows 10-compatible PC with sufficient resources for software dependencies above.
1. Microsoft HoloLens - you can also use the HoloLens Emulator, available for Visual Studio 2017 here: https://docs.microsoft.com/en-us/windows/mixed-reality/using-the-hololens-emulator

# Getting Started

In this guide, we will step through building a HoloLens app from start to finish in Unity 2018 and Visual Studio 2017. These steps include:


>1. Setting up Unity for HoloLens development by creating a new project, installing Microsoft's HoloToolKit, and installing Children's Research Institute's Mixed Reality Starter Kit
>1. Configuring a new Unity project for HoloLens
>1. Configuring a new Unity scene for HoloLens
>1. Adding the Mixed Reality Starter Kit's prefab UI assets to the scene
>1. Adding a 3D model to the scene
>1. Wiring up button, gesture, and voice commands
>1. Building and deploying your project to HoloLens


1. **How to set up MixedRealityStarterKit with a new Unity project**
	

	1. Clone or download this repository from GitHub.
	1. Download Microsoft's Mixed Reality Toolkit for Unity version 2017.4.2.0 from https://github.com/Microsoft/MixedRealityToolkit-Unity/archive/2017.4.2.0.zip
	1. Open Unity and create a new project:
		1. Ensure that the 3D option is selected next to the project's name.
		1. Tip: Keep folder paths and project names short and do not include spaces in your project's name. Unity struggles with long file paths and file names as well as spaces in those paths.
		1. Example Project Name: MixedRealityStarterKitDemo
		1. Example Location: c:\u\ 
	1. Unity will create a folder based on your project name and build a folder structure and standard files for your new project inside the project's folder.
		1. For the example project name and location above, the folder hierarchy will look like this:
    ```
	C:\u\MixedRealityStarterKitDemo\
    ├───Assets
    ├───Library
    ├───Packages
    ├───ProjectSettings
    ├───Temp
    MixedRealityStarterKitDemo.sln
    ```
	3. Use Windows Explorer to copy the HoloToolkit folder from the Microsoft Mixed Reality Toolkit's Assets folder into your new project's Assets folder:
		1. In Windows Explorer, navigate to the extracted location of Microsoft's Mixed Reality Toolkit.
		1. Open the Assets folder at the root of the Mixed Reality Toolkit folder hierarchy.
		1. Copy the HoloToolkit folder.
		1. Navigate to the the location of your new Unity project.
		1. Double-click on the project's folder.
		1. Double-click on the Assets folder inside the project's folder.
		1. Paste the copied HoloToolkit folder into the project's Assets folder.

	3. Use Windows Explorer to copy the MixedRealityStarterKit folder from this git repo into your new project's Assets folder:
		1. In Windows Explorer, navigate to the extracted location of this git repo.
		1. Copy the MixedRealityStarterKit folder.
		1. Navigate to the location of your new Unity project.
		1. Double-click on the project's folder.
		1. Double-click on the Assets folder inside the project's folder.
		1. Paste the copied MixedRealityStarterKit folder into the project's Assets folder.

    3. Switch back to Unity, where you may see a progress bar, indicating you need to wait for Unity to complete processing the files within the HoloToolKit and MixedRealityStarterKit folders. Once all progress bars complete, you can proceed to project configuration.


1. **Configuring a new Unity project for HoloLens**

	1. In Unity, remove the TextMeshPro software package from the project:
		1. Click the Window menu at the top of the screen and select Package Manager
		1. In the Packages window, click the "In Project" tab
		1. Click once on TextMesh Pro
		1. Click the Remove button near the top right corner of the window
		1. Once the progress bar completes, close the Packages window
		1. Click File -> Save Project

	1. In Unity, apply Mixed Reality Settings to the project:
		1. Click the Mixed Reality Toolkit menu at the top of the screen and select Configure -> Apply Mixed Reality Project Settings.
		1. In the Apply Mixed Reality Settings window, click the Apply button to apply these settings to your project. This readies the project to be built into a Visual Studio solution that can then be built and deployed to the HoloLens.
		1. Click on Unity's file menu and select Save Project.
	
	
1. **Configuring a new Unity scene for HoloLens**

	1. In Unity's Hierarchy panel, located on the left side of the screen, delete Main Camera and Directional Light:
		1. Right click on the words Main Camera and select Delete from the menu that appears.
		1. Right click on the words Directional Light and select Delete from the menu that appears.
	1. Apply Mixed Reality Scene Settings to your scene:
		1. Click the Mixed Reality Toolkit menu at the top of the screen and select Configure -> Apply Mixed Reality Scene Settings.
		1. In the Apply Mixed Reality Scene Settings window, click the Apply button to apply these settings to your scene. This step adds HoloLens-specific objects to the scene's hierarchy: MixedRealityCameraParent, DefaultCursor, and InputManager. 
	1. Add UWP (Universal Windows Platform) capabilities to your scene:
		1. Click the Mixed Reality Toolkit menu at the top of the screen and select Configure -> Apply UWP Capability Settings.
		1. Check the box next to Microphone, this enables your app to hear voice commands via the HoloLens' microphone.
		1. Uncheck the box next to Spatial Perception. We don't use that capability in this app.
		1. Click on Unity's File menu and select Save Scene.
1. **Adding Mixed Reality Starter Kit's prefab UI assets to your scene**
	1. In Unity's Project panel, located in the bottom left of the screen, click the Assets folder
	1. In the Assets list that appears to the right of the Project panel, double click MixedRealityStarterKit.
	1. In the list that appears, double click the Prefabs folder.
	1. In the list that appears, click and drag the "MixedRealityStarterKit Lighting" item into the Hierarchy panel in the top left corner of the screen and drop it into the list below InputManager.
	1. Click and drag the MixedRealityStarterKitUI item into the Hierarchy panel and drop it into the list below MixedRealityStarterKit Lighting.
	1. The Hierarchy panel should now have the following elements listed, and you will likely see the visible Mixed Reality Starter Kit UI appear in Unity's Scene panel. 
		```
		MixedRealityCameraParent
		DefaultCursor
		InputManager
		MixedRealityStarterKit Lighting
		MixedRealityStarterKitUI
		```
1. **Adding a 3D model to the scene**
	1. Create an empty Game Object that will be used as a container for your model and also enable voice commands:
		1. In Unity's Hierarchy panel, right click in the gray area beneath MixedRealityStarterKitUI
		1. Select Create Empty from the menu that appears.
		1. Right click on the "GameObject" item that appears in the Hierarchy panel, and select Rename.
		1. Change GameObject's name to "SpeechInputSourceTarget - Place Your Model Here" - this will be a good reminder in the future if you decide to replicate this project for additional models and apps.
	1. In Windows Explorer, copy your 3D model file into your Unity project's Assets folder, or use the sample model found in this repository:
		1. To use the sample model, copy the SampleModel folder from this repository into your project's Assets folder. 
			1. The SampleModel folder contains a 3D model, SampleModel.obj, and a folder named Materials, which contains multiple material files.
			1. Materials are used to assign colors and textures to portions (also known as meshes or mesh groups) of 3D models in Unity. If you'd like to know more, you can read about Materials, Shaders, and Textures in Unity's documentation here: https://docs.unity3d.com/Manual/Shaders.html
	1. In Unity's Project panel, navigate to the folder that contains the model file (e.g. Assets/SampleModel/)
	1. Drag the model file onto the "SpeechInputSourceTarget - Place Your Model Here" item in the Hierarchy panel. A blue circle will appear around "SpeechInputSourceTarget - Place Your Model Here" to indicate you are dropping the model into the SpeechInputSourceTarget container.
	1. Your Hierarchy should look like this now. You may need to click the triangle next to SpeechInputSourceTarget to verify your model was placed correctly:
![unity hierarchy w 3d model](https://user-images.githubusercontent.com/33156643/52063769-da289600-2538-11e9-8b5b-fe1af0365a8e.PNG)

	1. Resize your model as needed. You may need to scale your model's size up or down to get it to fit properly into the scene so you'll see it when the app launches. 
		1. In Unity's Hierarchy panel, click once on your model's name to select it.
		1. In Unity's Inspector panel, located on the right side of the screen, you will see a Transform section.
		1. In the Transform section, adjust the X, Y, and Z values next to the Scale heading up or down as needed to get your model to an appropriate size. Try to make it a little smaller than the visible user interface elements. Always set the Scale's X, Y, and Z values to be the same (e.g. X = 0.5, Y = 0.5, Z = 0.5) to increase or decrease size while keeping the model's aspect ratio intact (so it doesn't look squished or stretched).
		![unity model inspector scale](https://user-images.githubusercontent.com/33156643/52066128-8a000280-253d-11e9-92c6-c910fafae779.png)

			1. If you're using the SampleModel included in this repository, use these values: 
				```
				X = 0.002, Y = 0.002, Z = 0.002
				```
	1. Position the SpeechInputSourceTarget container as needed to ensure your model is visible when the app is launched on the HoloLens. Since your 3D model is contained inside the SpeechInputSourceTarget object, adjusting the position of SpeechInputSourceTarget also adjusts the position of the model itself. To position your model to be to the left of the visible UI buttons, do this:
		1. In Unity's Hierarchy panel, click once on "SpeechInputSourceTarget - Place Your Model Here" to select it.
		1. In Unity's Inspector panel, set the Position's Z value to 2. This will place the 3D model approximately 2 meters in front of the person wearing the HoloLens when the app is launched.
		1. If needed, adjust the X value of SpeechInputSourceTarget's Position to move the model left and right in the scene. For example, setting X = -0.05 will nudge the model slightly to the left of where it was originally positioned.
		1. You can also use Unity's Move Tool to click and drag your model into position. Read more about the Move Tool here: https://docs.unity3d.com/Manual/PositioningGameObjects.html
		1. The final result should have your 3D model positioned next to the visible UI buttons in the Scene area of the screen.
		1. Once you're happy with your 3D model's positioning, click Unity's File menu and select Save Scene.



1. **Wiring button, gesture, and voice commands**
	1. Add Mesh Collider and Manipulable components to all mesh groups in your 3D model:
		1. In Unity's Hierarchy panel, click the triangle next to your 3D model's name to expand its contents. You will see a list of items that correspond to different portions,  know in Unity as "mesh groups," "mesh parts," and or "meshes" of your 3D model depending on the software that created the model. 
			1. In our example model, clicking the triangle next to SampleModel displays a list of mesh groups from mmGroup0 to mmGroup5:
				```
				SampleModel
				├─── mmGroup0   
				├─── mmGroup1
				├─── mmGroup2
				├─── mmGroup3
				├─── mmGroup4
				├─── mmGroup5
				```
			1. Models can also contain nested mesh groups. If you're using your own 3D model and see more click-to-expand triangles after expanding the top level of your model, you are dealing with nested mesh groups. Click all of the triangles and expand all of the nested mesh groups you see. We can think of these nested mesh groups as being on levels. We'll talk about how to handle those below. Here's a hypothetical nested mesh group model hierarchy:
				```
				ComplexModel
				├─── mmGroup0    (These mesh groups are on Level 1)
				├─── mmGroup1
				├─── mmGroup2
				├─── mmGroup3
				├─── mmGroup4
					├─── mmGroup4_MeshPart0   (These mesh parts are on Level 2)
					├─── mmGroup4_MeshPart1
					├─── mmGroup4_MeshPart2
					├─── mmGroup4_MeshPart3
				├─── mmGroup5
				├─── mmGroup6
				```
		1. In Unity's Hierarchy panel, select all of the mesh groups in your model, but do not select the model's name itself or any nested mesh group containers that have click-to-expand triangles next to them.
			- To select multiple items in the Hierarchy panel, hold down the CTRL key as you click items in the hierarchy.
		1. In Unity's Inspector panel, click Add Component.
		1. In the search bar at the top of the Add Component window that appears, start typing the words "Mesh Collider." When you see Mesh Collider show up in the search results, click on the words Mesh Collider to add collision detection to all of your mesh groups. This enables HoloLens to detect when you've selected one of the mesh groups via air tap.
		![mesh collider](https://user-images.githubusercontent.com/33156643/52066439-2e824480-253e-11e9-853d-a0368fb2f09a.PNG)

		1. In the Inspector panel, click Add Component again.
		1. In the search bar at the top of the Add Component window that appears, start typing the word "Manipulable." When you see Manipulable show up in the search results, click once on the word Manipulable. This adds the Manipulable script component, which facilitates interacting with the model when the app is running.
		![manipulable](https://user-images.githubusercontent.com/33156643/52066530-5d001f80-253e-11e9-8d44-0a874ee14159.PNG)

		1. If your model contains nested mesh groups, configure the Manipulable script for those nested mesh groups:
			1.  In Unity's Hierarchy panel, select one or more nested mesh groups that are on the same level. In the ComplexModel example above, we'd select mmGroup4_MeshPart0, mmGroup4_MeshPart1, mmGroup4_MeshPart2, and mmGroup4_MeshPart3.
			1. In Unity's Inspector panel, under Manipulable (Script), adjust the Depth value to match the level of your selected mesh group(s). In the ComplexModel example above, we'd set depth to "Two" for mmGroup4_MeshPart0, mmGroup4_MeshPart1, mmGroup4_MeshPart2, and mmGroup4_MeshPart3.
			1. The Mixed Reality Starter Kit's Manipulable script can currently handle up to 3 levels of depth.
			![manipulable levels](https://user-images.githubusercontent.com/33156643/52066636-92a50880-253e-11e9-8b31-bf1f544ce128.PNG)
	1. Add Speech Input Source component to SpeechInputSourceTarget
		1. In Unity's Hierarchy panel, click once on "SpeechInputSourceTarget - Place Your Model Here"
		1. In Unity's Inspector panel, click Add Component.
		1. In the search bar at the top of the Add Component window that appears, start typing the words "Speech Input Source."
		1. When you see Speech Input Source show up in the search results, click once on the words Speech Input Source. This adds the Speech Input Source script component, which facilitates voice interactions.
		1. Still in the Inspector panel, in the Speech Input Source (Script) section, add keywords to Speech Input Source by click the tiny + button located below and to the right of the Keywords heading. Assign the following keywords and key shortcuts:
			![speech input source](https://user-images.githubusercontent.com/33156643/52066769-d7c93a80-253e-11e9-9317-4d3289353909.PNG)
    1. Add actions to visible UI buttons' On Click event handlers
		1. In Unity's Hierarchy panel, click the triangle next to MixedRealityStarterKitUI to expand its contents.
		1. Click the triangle next to UIAllVisibleControls to expand its contents.
		1. Click the triangle next to UIButtonControls to expand its contents.
		1. A list of button elements will appear below UIButtonControls. Do the following steps for each button listed here:
			
			```
			ButtonRotateUp
			ButtonRotateDown
			ButtonRotateLeft
			ButtonRotateRight
			ButtonSizeUp
			ButtonSizeDown
			ButtonUndoHide
			ButtonResetAll
			```
			
			1. Click once on the button's name (for example, "ButtonRotateUp") to select the up button element in the scene.
			1. In Unity's Inspector panel, scroll down to the On Click () section.
			1. In the On Click () section, click the light gray circle next to the words "None (Object)."
			1. In the Select Object window that appears, click the Scene tab.
			1. In the Select Object's Scene tab, scroll down and double-click on the word "mmGroup0" to select the mmGroup0 mesh group as the target object of the On Click event handler for the up button.
			1. In the On Click () section, you should now see mmGroup0 listed under the Runtime Only heading.
			1. In the On Click () section, click the "No Function" dropdown, then hover your mouse over the word Manipulable in the nested menu that appears.
			1. In the submenu that appears, select the function that matches the name of your button (for ButtonRotateUp, select "Manipulable -> Rotate Up ()").
			&nbsp;

			![button on click manipulable](https://user-images.githubusercontent.com/33156643/52084779-75852f80-2568-11e9-83d2-b0ed62961619.gif)
			&nbsp;
			*Example: Connecting ButtonRotateUp with the RotateUp () function.*
			<br>

			1. The goal is to assign mmGroup0 as the target with the proper action to each button:
			```
			Button Name   		Select Object	Function
			-----------------	-------------	-----------
			ButtonRotateUp		mmgroup0	Manipulable -> RotateUp ()
			ButtonRotateDown	mmgroup0	Manipulable -> RotateDown ()
			ButtonRotateLeft   	mmgroup0	Manipulable -> RotateLeft ()
			ButtonRotateRight  	mmgroup0	Manipulable -> RotateRight ()
			ButtonSizeUp		mmgroup0	Manipulable -> ScaleUp ()
			ButtonSizeDown		mmgroup0	Manipulable -> ScaleDown ()
			ButtonUndoHide		mmgroup0	Manipulable -> UndoLastHide ()
			ButtonResetAll		mmgroup0	Manipulable -> ResetAll ()
			```
	1. Once you've assigned functions to all of the buttons, click Unity's File menu and select Save Scene.
	1. 	Congratulations, you've made it a long way, but you're not quite out of the woods yet! You should be ready to try to build and deploy your app at this point.

1. **Building and deploying your project to HoloLens**

	1. Connect the HoloLens to your PC via USB.
	1. In Unity, with your project open, click the File menu and select "Build Settings..."
	1. In the Build Settings window that appears, click the Build button near the bottom right corner of the window.
	1. Unity will prompt you to select a folder in which to compile source code that Visual Studio will use to build and deploy the HoloLens app. Near the top of the window that appears, click "New folder" and name the folder App.
	1. In the area below the New Folder button, click once on the App folder to highlight it, then click Select Folder near the bottom right corner of the window.
	1. A progress bar will appear as Unity builds this project into a Visual Studio Solution, which will be used to publish the app to the HoloLens in the next steps.
	1. A new Windows Explorer window will pop open when Unity is done building. 
	1. Open the App folder in the window that appears.
	1. Double-click the "[Your project name here].sln" file inside the App folder to open it in Visual Studio.
	1. Once Visual Studio is open, switch to Release mode, change the platform to x86, and change the build target to Device:
		1. Click the black downward pointing triangle next to the word Debug in the dropdown menu near the top of the screen and select Release.
		1. Click the black downward pointing triangle next to the word ARM in the dropdown menu near the top of the screen and select x86.
		1. Click the black downward pointing triangle next to the word Local Machine in the dropdown menu near the top of the screen and select Device.
	1. Click the green triangle to the left of the word Device in the dropdown menu near the top of the screen to build and deploy the app to your HoloLens. The Output panel near the bottom of the Visual Studio screen will display build and deployment progress.
	1. Put on your HoloLens while you wait for build and deployment to complete. The app should launch automatically. See the troubleshooting section below for common error messages and guidance.

# Troubleshooting
1. Build and Deploy issues:
    1. Visual Studio Error: Access is denied
        - Typically, this error indicates that the app did build and deploy successfully, but Visual Studio was unable to launch the app on the HoloLens automatically for some reason. In our experience, as long as Visual Studio's build output window shows build and deploy were successful, you should be able to put on the HoloLens and launch the app.
        - Potential Resolution 1: Uninstall the app from the HoloLens, then use Visual Studio to build and deploy the app again.
        - Potential Resolution 2: Delete the App folder that contains the Visual Studio solution, create a new, empty App folder in its place, and redo all Build and Deploy steps above.
    1. Visual Studio Error: Could not deploy while a user-defined section is open
        - We tend to see this error when we are repeatedly building and deploying to HoloLens after making small adjustments to our Unity scene or scripting. If you see this error, your Visual Studio project did not build and deploy to the HoloLens properly.
        - Potential Resolution 1: Clean the Visual Studio solution and try running the app without debugging again. 
        - Potential Resolution 2: Delete the App folder that contains the Visual Studio solution, create a new, empty App folder in its place, and redo all Build and Deploy steps above.



# Contribute
1. Raise an Issue: If you would like to make a change in the code base, please log an issue and explain what you are changing/updating/adding and why. 
	- We will have a brief discussion about the change and make a decision based on our combined evaluation of the issue.
2. Create a Pull Request: After you receive a go ahead on the issue, please create a pull request to merge your topic branch into the master branch with issue information in pull request's description.
Once the pull is received, we will evaluate the changes. If pull request is approved, we will merge the code.
We aim to review pull request changes in a week.
Thank you for contributing to MRStarterKit!



