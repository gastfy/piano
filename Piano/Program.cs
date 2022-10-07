namespace Piano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] defaultOctave = new double[10] { 16.35, 17.32, 18.35, 19.45, 20.60, 21.83, 23.12, 24.5, 25.96, 27.5};
            double[] UsingOctave = defaultOctave;
            bool nextCircle = true;
            while (nextCircle)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
             
                //Блок с Ф-кнопками и вывод звука
                switch (key.Key)
                {
                    case ConsoleKey.Escape: nextCircle = false; break;
                    case ConsoleKey.F1:
                        UsingOctave = OctaveChange(3, defaultOctave);
                        break;
                    case ConsoleKey.F2:
                        UsingOctave = OctaveChange(4, defaultOctave);
                        break;
                    case ConsoleKey.F3:
                        UsingOctave = OctaveChange(5, defaultOctave);
                        break;
                    case ConsoleKey.F4:
                        UsingOctave = OctaveChange(6, defaultOctave);
                        break;
                    case ConsoleKey.F5:
                        UsingOctave = defaultOctave; UsingOctave = OctaveChange(7, defaultOctave);
                        break;
                    case ConsoleKey.F6:
                        UsingOctave = defaultOctave; UsingOctave = OctaveChange(8, defaultOctave);
                        break;
                    case ConsoleKey.Q:
                        noteOutput(UsingOctave[0], 600);
                        break;
                    case ConsoleKey.W:
                        noteOutput(UsingOctave[1], 600);
                        break;
                    case ConsoleKey.E:
                        noteOutput(UsingOctave[2], 600);
                        break;
                    case ConsoleKey.R:
                        noteOutput(UsingOctave[3], 600);
                        break;
                    case ConsoleKey.T:
                        noteOutput(UsingOctave[4], 600);
                        break;
                    case ConsoleKey.Y:
                        noteOutput(UsingOctave[5], 600);
                        break;
                    case ConsoleKey.A:
                        noteOutput(UsingOctave[6], 600);
                        break;
                    case ConsoleKey.S:
                        noteOutput(UsingOctave[7], 600);
                        break;
                    case ConsoleKey.D:
                        noteOutput(UsingOctave[8], 600);
                        break;
                    case ConsoleKey.F:
                        noteOutput(UsingOctave[9], 600);
                        break;
                }
            }
        }

        //Обозначение ГЦ нот
        static double[] OctaveChange(int FCount, double[] defaultOctave)
        {
            if (FCount > 3) {FCount = (int)Math.Pow(2, FCount);}
            if (FCount == 3) { FCount = (int)Math.Pow(2, 2); }
            double[] deftwoOctave = new double[10];
            for (int i = 0; i < deftwoOctave.Length; i++)
            {
                deftwoOctave[i] = defaultOctave[i] * FCount;
            }
            return deftwoOctave;
        }

        //Вывод звука
        static void noteOutput(double HZ, int duration) { int Hz = Convert.ToInt32(Math.Round(HZ)); Console.Beep(Hz, duration); }
    }
}