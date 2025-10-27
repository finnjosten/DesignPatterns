using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            /* Define and instantiate the following Vendor classes
             * Kitchen Light : Light
             * Livingroom Light : Light
             * Livingroom ceiling fan : CeilingFan
             * Garage door: Garagedoor
             * Stereo : Stereo
             */
            Light kitchenLight = new Light("Kitchen");
            
            Light livingRoomLight = new Light("Living Room");
            
            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room");

            Light garageLight = new Light("Garage");
            GarageDoor garageDoor = new GarageDoor(garageLight);
            
            Stereo stereo = new Stereo();

            // Define and instantiate an Off and On command for each Vendor class
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            CeilingFanHighCommand ceilingFanOn = new CeilingFanHighCommand(livingRoomCeilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(livingRoomCeilingFan);

            GarageDoorUpCommand garageDoorOn = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorOff = new GarageDoorDownCommand(garageDoor);

            StereoOnWithCdCommand stereoOn = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            /* Set the On and Off commands to the appropriate slot:
             * 
             * 1: Living Room light
             * 2: Kitchen light
             * 3: Livingroom ceiling fan
             * 4: Garage door
             * 5: Stereo
             */

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remoteControl.SetCommand(3, garageDoorOn, garageDoorOff);
            remoteControl.SetCommand(4, stereoOn, stereoOff);

            Console.WriteLine(remoteControl);

            // Test the pressing of Buttons here. Don't forget to test the Undo button
            Console.WriteLine("---- Testing Remote Control ----");
            Console.WriteLine("Slot 0 - Living Room Light");
            Console.WriteLine("Pressing on:");
            remoteControl.OnButtonWasPushed(0);
            Console.WriteLine("Pressing off:");
            remoteControl.OffButtonWasPushed(0);

            Console.WriteLine("\nSlot 1 - Kitchen Light");
            Console.WriteLine("Pressing on:");
            remoteControl.OnButtonWasPushed(1);
            Console.WriteLine("Pressing off:");
            remoteControl.OffButtonWasPushed(1);

            Console.WriteLine("\nSlot 2 - Living Room Ceiling Fan");
            Console.WriteLine("Pressing on:");
            remoteControl.OnButtonWasPushed(2);
            Console.WriteLine("Pressing off:");
            remoteControl.OffButtonWasPushed(2);

            Console.WriteLine("\nSlot 3 - Garage Door");
            Console.WriteLine("Pressing on:");
            remoteControl.OnButtonWasPushed(3);
            Console.WriteLine("");
            remoteControl.OffButtonWasPushed(3);

            Console.WriteLine("\nSlot 4 - Stereo");
            Console.WriteLine("Pressing on:");
            remoteControl.OnButtonWasPushed(4);
            Console.WriteLine("Pressing off:");
            remoteControl.OffButtonWasPushed(4);


            Console.WriteLine("\n\n---- Undo testing ----");
            Console.WriteLine("Last press");
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\nSecond to last press");
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\nThird to last press");
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\nFourth to last press");
            remoteControl.UndoButtonWasPushed();
        }
    }
}