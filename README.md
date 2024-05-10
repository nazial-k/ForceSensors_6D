# ForceSensors_6D

Simulation and visualization of force sensors in a 3D space

## Camera Controls

Camera controls similar to navigation within Unity editors are included to allow for effective viewing using a mouse:

- Hold down right-click and drag to rotate view.
- Hold down scroll-wheel and drag to pan.
- Zoom in and out using scroll-wheel.

## Layout Description

The UI includes 4 sections to simulate data readings from 4 sensors.

### Buttons:

- **Get Position:** Generates a new position for a sensor. The position ranges are set so the 3 sensors conveniently stay within individual quadrants. The maximum displacement from either x and y axes is set at 500m.

- **Generate Position:** Generates a new force for the sensor. The arrow rotates to face the direction of the force and changes color based on the magnitude of the force generated. The maximum magnitude possible is calculated dynamically, and the color reflects the force ranging from green (minimum) to red (maximum).

### Inputs:

- Enter the minimum allowed value of force generated in each direction. If the minimum exceeds the current maximum, the maximum is adjusted to be 500 units higher than the minimum.
- Enter the maximum allowed value of force generated in each direction. If the maximum becomes lower than the current minimum, the minimum is adjusted to be 500 units lower than the maximum.

## Running the Program

You can run the program by simply executing the provided build file (`ForceSensors_6D.exe`) within the Builds folder.
