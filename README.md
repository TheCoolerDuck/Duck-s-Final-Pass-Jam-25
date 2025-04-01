Quantized Luminosity Post Effect
This folder contains assets for a Standard Render Pipeline scene in Unity.

Contents
Post-processing effect that quantizes luminosity.

View controller for moving the camera during play mode.

C# script to render the post effect.

Banana Man model (created by Banana Yellow Games) for testing.

How to Use
Attach the Test1.cs script to your camera. (Ignore any initial errors.)

Assign NewImageEffectShader.shader to the shader field in Test1.cs.

Troubleshooting
If the effect isn’t working:

Ensure Unity is using the Standard Render Pipeline (No render pipeline should be selected in Edit > Project Settings > Graphics).

Verify that Test1.cs is attached to a camera.

This was designed for Unity 2022.3.21f1—try using this version if issues arise. (Other versions may work, but this is the tested one.)
