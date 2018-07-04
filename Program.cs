using System;
using DesignPatterns.Creational.Factory;
using DesignPatterns.Structural.Adapter;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FactoryMethod
            // var monopolowy = new Monopolowy();
            // monopolowy.SellAndDrinkBeer(1);
            // monopolowy.SellAndDrinkBeer(3);
            // monopolowy.SellAndDrinkBeer(7);
            #endregion
            //abstract factory
            #region Adapter
            var usb = new UsbPendrive();
            usb.Connect(new UsbPcPort());
            usb.Connect(new PortableSpeaker());
            //line below doesn't compile
            //usb.Connect(new SataSocket());
            usb.Connect(new UsbToSataAdapter(new SataSocket()));
            #endregion
        }
    }
}
