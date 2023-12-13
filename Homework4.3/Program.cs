/*Створіть 2 інтерфейси IPlayable та IRecodable.
 * У кожному з інтерфейсів створіть по 3 методи 
 * 
 * void Play() / void Pause() / void Stop() та void Record() / void Pause() / void Stop() відповідно.
 * 
 * Створіть похідний клас Player від базових інтерфейсів IPlayable та IRecodable. 
 * Написати програму, яка виконує програвання та запис.*/

namespace Homework4._3
{
    

    
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("play");
        }
         void IPlayable.Stop() 
        {
            Console.WriteLine("stop");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("pause");
        }
        public void Record()
        {
            Console.WriteLine("record");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("pause");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("stop");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLAY: ");
            IPlayable playable = new Player();
            playable.Play();
            playable.Stop();
            playable.Pause();

            Console.WriteLine();
            Console.WriteLine("RECORD: ");
            IRecodable recodable = new Player();
            recodable.Record();
            recodable.Pause();
            recodable.Stop();

            Console.ReadKey();      

        }
    }
}