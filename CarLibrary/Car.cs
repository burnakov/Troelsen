using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLibrary
{
    public enum EngineState
    {
        engineAlive,
        engineDead
    }
    public enum MusicMedia
    {
        musicCd,
        musicTape,
        musicRadio,
        musicMp3
    }
    public abstract class Car
    {
        protected EngineState engineStatus = EngineState.engineAlive;

        public string PetName { get; set; }
        public int CurrSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public EngineState EngineStatus
        {
            get { return engineStatus; }
        }

        public Car()
        {
            MessageBox.Show("CarLibrary Ver. 2.0.0.0");
        }
        public Car(string name, int max, int curr)
        {
            MessageBox.Show("CarLibrary Ver. 2.0.0.0");
            PetName = name;
            MaxSpeed = max;
            CurrSpeed = curr;
        }

        public void TurnOnMusic(bool musicOn, MusicMedia mm)
        {
            if (musicOn)
                MessageBox.Show(string.Format("Jaming {0}", mm));
            else
                MessageBox.Show("Quite time");
        }

        public abstract void TurboBoost();
    }
}
