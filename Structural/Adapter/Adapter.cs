namespace DesignPatterns.Structural.Adapter
{
    public interface IPluggableUSB{
        void PlugIn();
    }
    public class UsbPcPort : IPluggableUSB{
        public void PlugIn(){
            System.Console.WriteLine("Plugging in and mounting disc");
        }
    }
    public class PortableSpeaker : IPluggableUSB {
             public void PlugIn(){
            System.Console.WriteLine("Plugging in, seeking for music and playing");
        }   
    }
    public class UsbPendrive{
        public void Connect(IPluggableUSB usbPort){
            usbPort.PlugIn();
        }
    }
    public class SataSocket {
        public void Latch(){
            System.Console.WriteLine("Latching disc to sata connector");
        }
    }
    public class UsbToSataAdapter : IPluggableUSB
    {
        private SataSocket mSataSocket;
        public UsbToSataAdapter(SataSocket socket){
            this.mSataSocket = socket;
        }
        public void PlugIn(){
            mSataSocket.Latch();
        }
    }
}