using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Threading.Tasks;

namespace Lift
{
    public partial class Form1 : Form
    {
        private int currentFloor = 0; // Track the current floor
        private int targetFloor; // Target floor
        private const int elevatorSpeed = 5; // Speed of movement
        private bool isMoving = false; // Checks if elevator is moving
        private const int Floor1Position = 353; // Position of Floor 1
        private const int Floor2Position = 60;  // Position of Floor 2
        private int doorOpenDuration = 0;

        private IDoorState currentDoorState; // Current door state
        private bool openingDoors = false;
        private bool closingDoors = false;
        private int doorStep = 2; // Controls the speed of door movement

        // Define initial door positions for each floor
        private int initialLeftDoorPosition;
        private int initialRightDoorPosition;
        private int initialLeftDoor1Position;
        private int initialRightDoor1Position;

        private Image upImage;
        private Image downImage;

        private SoundPlayer doorOpenSound;
        private SoundPlayer doorCloseSound;
        private SoundPlayer moveElevator;

        private System.Windows.Forms.Timer doorAnimationTimer;
        private System.Windows.Forms.Timer autoCloseTimerControl;
        private System.Windows.Forms.Timer doorMovementTimer; // Renamed to avoid conflict
        private System.Windows.Forms.Timer elevatorMovementTimer; // Renamed to avoid conflict

        public Form1()
        {
            InitializeComponent();
            currentDoorState = new ClosedState();

            // Load images
            upImage = Image.FromFile(@"Resources\ug.png");
            downImage = Image.FromFile(@"Resources\dg.png");

            animation.SizeMode = PictureBoxSizeMode.StretchImage;

            doorOpenSound = new SoundPlayer(@"Resources\opensound.wav");
            doorCloseSound = new SoundPlayer(@"Resources\opensound.wav");
            moveElevator = new SoundPlayer(@"Resources\move.wav");

            initialLeftDoorPosition = leftdoor1.Left;
            initialRightDoorPosition = rightdoor1.Left;
            initialLeftDoor1Position = leftdoor2.Left;
            initialRightDoor1Position = rightdoor2.Left;

            doorAnimationTimer = new System.Windows.Forms.Timer();
            doorAnimationTimer.Interval = 1000; // 1 second interval
            doorAnimationTimer.Tick += doorAnimationTimer_Tick; // Attach the tick event

            doorMovementTimer = new System.Windows.Forms.Timer(); // Use renamed timer
            doorMovementTimer.Interval = 50; // Timer for door movement
            doorMovementTimer.Tick += doorTimer_Tick;

            elevatorMovementTimer = new System.Windows.Forms.Timer(); // Use renamed timer
            elevatorMovementTimer.Interval = 100; // Timer for elevator movement
            elevatorMovementTimer.Tick += elevatorTimers_Tick;

            UpdateDisplay();
        }

        private void btnOpenDoor_Click(object sender, EventArgs e)
        {
            if (!isMoving) // Only open if elevator is not moving
            {
                currentDoorState.OpenDoor(this);
                ToggleDoorButtons();
            }
        }

        private void btnCloseDoor_Click(object sender, EventArgs e)
        {
            if (!isMoving) // Only close if elevator is not moving
            {
                currentDoorState.CloseDoor(this);
                ToggleDoorButtons();
            }
        }

        private void RequestFloor(int floor)
        {
            if (!isMoving && currentFloor != floor && !closingDoors) // Ensure doors are not closing when requesting
            {
                targetFloor = floor;

                if (currentDoorState is OpenState) // Close the doors first if they're open
                {
                    currentDoorState.CloseDoor(this);
                    ToggleDoorButtons();
                }
                else if (currentDoorState is ClosedState) // If doors are already closed, start moving
                {
                    StartMoving();
                }
            }
        }

        private void StartMoving()
        {
            isMoving = true;
            ToggleButtons(false);
            animation.Image = targetFloor > currentFloor ? upImage : downImage; // Start animation
            elevatorMovementTimer.Start(); // Start elevator movement timer
        }

        private void elevatorTimers_Tick(object? sender, EventArgs e)
        {
            MoveElevator();
        }

        private void MoveElevator()
        {
            if (currentFloor < targetFloor)
            {
                if (pictureBox1.Top > Floor2Position)
                {
                    pictureBox1.Top -= elevatorSpeed;
                }
                else
                {
                    ArrivedAtFloor();
                }
            }
            else if (currentFloor > targetFloor)
            {
                if (pictureBox1.Top < Floor1Position)
                {
                    pictureBox1.Top += elevatorSpeed;
                }
                else
                {
                    ArrivedAtFloor();
                }
            }

            // If elevator is moving, show the animation in the PictureBox
            if (isMoving)
            {
                animation.Image = targetFloor > currentFloor ? upImage : downImage; // Update animation PictureBox
            }
        }

        private void ArrivedAtFloor()
        {
            elevatorMovementTimer.Stop();
            isMoving = false;
            currentFloor = targetFloor;
            UpdateDisplay();
            ToggleButtons(true); // Re-enable buttons when elevator stops moving

            // Clear the image after arriving
            pictureBox1.Image = null;
            animation.Image = null; // Clear the animation PictureBox

            // Open door upon arrival
            currentDoorState.OpenDoor(this);
        }

        private void ToggleButtons(bool isEnabled)
        {
            btnRequestFloor0.Enabled = isEnabled;
            btnRequestFloor1.Enabled = isEnabled;
            callDown.Enabled = isEnabled;
            callUp.Enabled = isEnabled;
            btnOpenDoor.Enabled = isEnabled;
            btnCloseDoor.Enabled = isEnabled;
        }

        private void ToggleDoorButtons()
        {
            btnOpenDoor.Enabled = currentDoorState is ClosedState;
            btnCloseDoor.Enabled = currentDoorState is OpenState;
        }

        // Door State Interface
        private interface IDoorState
        {
            void OpenDoor(Form1 form);
            void CloseDoor(Form1 form);
        }

        // Open State
        private class OpenState : IDoorState
        {
            public void OpenDoor(Form1 form)
            {
                // Doors are already open, do nothing
            }

            public void CloseDoor(Form1 form)
            {
                form.currentDoorState = new ClosedState();
                form.closingDoors = true;
                form.doorMovementTimer.Start(); // Use renamed timer
            }
        }

        // Closed State
        private class ClosedState : IDoorState
        {
            public void OpenDoor(Form1 form)
            {

                form.currentDoorState = new OpenState();
                form.openingDoors = true;
                form.doorMovementTimer.Start(); // Use renamed timer
            }

            public void CloseDoor(Form1 form)
            {
                form.closingDoors = true;
                form.doorMovementTimer.Start();
            }
        }

        // Method to gradually open/close doors for Floor 1
        private void OpenDoorsFloor1()
        {
            if (leftdoor1.Left > initialLeftDoorPosition - 100)
                leftdoor1.Left -= doorStep;
            if (rightdoor1.Left < initialRightDoorPosition + 100)
                rightdoor1.Left += doorStep;

            if (leftdoor1.Left <= initialLeftDoorPosition - 70)
            {
                doorOpenDuration = 0; // Reset the timer
                doorAnimationTimer.Start(); // Start the timer for auto close
            }
        }

        private void CloseDoorsFloor1()
        {
            if (leftdoor1.Left < initialLeftDoorPosition)
                leftdoor1.Left += doorStep;
            if (rightdoor1.Left > initialRightDoorPosition)
                rightdoor1.Left -= doorStep;
        }

        // Method to gradually open/close doors for Floor 2
        private void OpenDoorsFloor2()
        {
            if (leftdoor2.Left > initialLeftDoor1Position - 100)
                leftdoor2.Left -= doorStep;
            if (rightdoor2.Left < initialRightDoor1Position + 100)
                rightdoor2.Left += doorStep;

            if (leftdoor2.Left <= initialLeftDoor1Position - 70)
            {
                doorOpenDuration = 0; // Reset the timer
                doorAnimationTimer.Start(); // Start the timer for auto close
            }
        }

        private void CloseDoorsFloor2()
        {
            if (leftdoor2.Left < initialLeftDoor1Position)
                leftdoor2.Left += doorStep;
            if (rightdoor2.Left > initialRightDoor1Position)
                rightdoor2.Left -= doorStep;
        }

        private void doorTimer_Tick(object? sender, EventArgs e)
        {
            if (openingDoors)
            {
                if (currentFloor == 0)
                    OpenDoorsFloor1();
                else if (currentFloor == 1)
                    OpenDoorsFloor2();

                if ((currentFloor == 0 && leftdoor1.Left <= initialLeftDoorPosition - 70) ||
                    (currentFloor == 1 && leftdoor2.Left <= initialLeftDoor1Position - 70))
                {
                    doorMovementTimer.Stop(); // Stop the door movement timer
                    openingDoors = false;
                }
            }
            else if (closingDoors)
            {
                if (currentFloor == 0)
                    CloseDoorsFloor1();
                else if (currentFloor == 1)
                    CloseDoorsFloor2();

                // Check if doors are fully closed
                if ((currentFloor == 0 && leftdoor1.Left >= initialLeftDoorPosition) ||
                    (currentFloor == 1 && leftdoor2.Left >= initialLeftDoor1Position))
                {
                    doorMovementTimer.Stop();
                    closingDoors = false;

                    // Only start moving after doors are fully closed
                    if (targetFloor != currentFloor) // Ensure there is a target floor to move to
                    {
                        StartMoving();
                    }
                }
            }
        }


        public void UpdateDisplay()
        {
            lblCurrentFloor.Text = $"Floor {currentFloor + 1}";
            lblCurrentFloor0.Text = $"Floor {currentFloor + 1}";
            lblFloor1Status.Text = "Floor G";
            lblFloor2Status.Text = "Floor 1";
        }


        // Event handlers for button clicks for requesting floors
        private void btnRequestFloor0_Click(object sender, EventArgs e)
        {
            RequestFloor(0); // Request Floor 0
        }


        private void leftdoor2_Click(object sender, EventArgs e)
        {
            // Handle click for left door 2 (if any specific logic needed)
        }

        private void animation_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRequestFloor1_Click_1(object sender, EventArgs e)
        {
            RequestFloor(1); // Request Floor 1
        }

        private void callDown_Click(object sender, EventArgs e)
        {
            // Logic to handle the call down button click
            RequestFloor(0);
        }

        private void callUp_Click(object sender, EventArgs e)
        {
            RequestFloor(1);
        }

        private void doorAnimationTimer_Tick(object sender, EventArgs e)
        {
            doorOpenDuration++;

            if (doorOpenDuration >= 5) // Check if doors have been open for 5 seconds
            {
                btnCloseDoor.PerformClick(); // Simulate button click to close doors
                doorAnimationTimer.Stop(); // Stop the timer
            }
        }

        private void Emergency_Click(object sender, EventArgs e)
        {
            // Stop elevator movement immediately
            elevatorMovementTimer.Stop();
            isMoving = false;
            closingDoors = false;
            openingDoors = false;

            // Stop door movement if it's in progress
            doorMovementTimer.Stop();
            ToggleButtons(false);
            moveElevator.Stop();

            lblCurrentFloor.Text = "Stopped";
            lblCurrentFloor0.Text = "Stooped";

        }

        private void leftdoor1_Click(object sender, EventArgs e)
        {
            // Handle click for left door 1 (if any specific logic needed)
        }

        private void rightdoor1_Click(object sender, EventArgs e)
        {
            // Handle click for right door 1 (if any specific logic needed)
        }

        private void rightdoor2_Click(object sender, EventArgs e)
        {
            // Handle click for right door 2 (if any specific logic needed)
        }

    }
}
