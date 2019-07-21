using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Timers;
using System.Media;

namespace TABGameSaver
{
    class Program
    {
        static string location = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        static Timer timer = new Timer(5000);
        static string File1Location = Directory.GetCurrentDirectory() + @"\Survival.zxcheck";
        static string File1GBLocation = Directory.GetCurrentDirectory() + @"\Survival_backup.zxcheck";
        static string File1BackupLocation = Directory.GetCurrentDirectory() + @"\TABGameSaverFiles\Survival.zxcheck";
        static string File1GBBackupLocation = Directory.GetCurrentDirectory() + @"\TABGameSaverFiles\Survival_backup.zxcheck";
        static string File2Location = Directory.GetCurrentDirectory() + @"\Survival.zxsav";
        static string File2GBLocation = Directory.GetCurrentDirectory() + @"\Survival_backup.zxsav";
        static string File2BackupLocation = Directory.GetCurrentDirectory() + @"\TABGameSaverFiles\Survival.zxsav";
        static string File2GBBackupLocation = Directory.GetCurrentDirectory() + @"\TABGameSaverFiles\Survival_backup.zxsav";
        static string DirectoryLocation = Directory.GetCurrentDirectory() + @"\TABGameSaverFiles";
        public static void Main(string[] args)
        {
            timer.Elapsed += TimerElapsed;
            timer.AutoReset = true;
            Console.WriteLine("They Are Billions Game Saver\nVersion: 1.1.0\nAuthor: Skeletonek\nCopyright 2019\n\n");
            Console.WriteLine("Proszę umieścić plik w katalogu z save'ami do gry They Are Billions\n(Dokumenty\\My Games\\They Are Billions\\Saves)\n");
            Console.WriteLine("Aplikacja wykrywa tylko zapis z domyślną nazwą trybu survival.\nZmiana nazwy zapisu będzie skutkować nie działaniem aplikacji!\n");
            Console.WriteLine("Czy aplikacja znajduje się w katalogu z zapisami do gry They Are Billions? (Y/N): ");
            SystemSounds.Asterisk.Play();
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine("\n\n");
                timer.Enabled = true;
                if (!Directory.Exists(DirectoryLocation))
                {
                    try
                    {
                        Directory.CreateDirectory(DirectoryLocation);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(location);
                        Console.WriteLine("!!! Nie można stworzyć katalogu aplikacji. Program nie będzie dalej kontynuował pracy !!!\n");
                        SystemSounds.Hand.Play();
                        timer.Enabled = false;
                    }
                    if (Directory.Exists(DirectoryLocation))
                    {
                        Console.WriteLine("Utworzono katalog aplikacji.");
                        SystemSounds.Beep.Play();
                    }
                }
                for (int i = 0; i >= 0; i++)
                {
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                        return;
                }
            }
        }

        public static void TimerElapsed(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Sprawdzanie plików...");
            /*if (File.Exists(File1GBLocation) && File.GetLastWriteTime(File1GBLocation) != File.GetLastWriteTime(File1Location))
            {
                Console.WriteLine("Wykryto plik \"Survival_backup.zxcheck\". Próba podmiany pliku backup na zwykły...");
                try
                {
                    File.Delete(File1Location);
                    File.Copy(File1GBLocation, File1Location);
                }
                catch (Exception)
                {
                    Console.WriteLine("\n!!! Nie można podmienić pliku !!!\n");
                    SystemSounds.Hand.Play();
                }
                if (File.GetLastWriteTime(File1Location) == File.GetLastWriteTime(File1GBLocation))
                {
                    Console.WriteLine("Podmiana pliku zakończona pomyślnie");
                    SystemSounds.Beep.Play();
                }
            }
            if (File.Exists(File2GBLocation) && File.GetLastWriteTime(File2GBLocation) != File.GetLastWriteTime(File2Location))
            {
                Console.WriteLine("Wykryto plik \"Survival_backup.zxsav\". Próba podmiany pliku backup na zwykły...");
                try
                {
                    File.Delete(File2Location);
                    File.Copy(File2GBLocation, File2Location);
                }
                catch (Exception)
                {
                    Console.WriteLine("\n!!! Nie można podmienić pliku !!!\n");
                    SystemSounds.Hand.Play();
                }
                if (File.GetLastWriteTime(File2Location) == File.GetLastWriteTime(File2GBLocation))
                {
                    Console.WriteLine("Podmiana pliku zakończona pomyślnie");
                    SystemSounds.Beep.Play();
                }
            }*/
            if (File.Exists(File1Location))
            {
                if (!File.Exists(File1BackupLocation))
                {
                    Console.WriteLine("Wykryto plik \"Survival.zxcheck\". Próba wykonania kopii pliku...");
                    try
                    {
                        File.Copy(File1Location, File1BackupLocation);
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("\n!!! Nie można wykonać kopii pliku \"Survival.zxcheck\" !!!\n");
                        SystemSounds.Hand.Play();
                    }
                    if (File.Exists(File1BackupLocation))
                    {
                        Console.WriteLine("Kopia pliku \"Survival.zxcheck\" wykonana pomyślnie");
                        SystemSounds.Beep.Play();
                    }
                }
                if (File.GetLastWriteTime(File1Location) != File.GetLastWriteTime(File1BackupLocation))
                {
                    Console.WriteLine("Wykryto zmiany w pliku \"Survival.zxcheck\". Próba wykonania kopii pliku...");
                    try
                    {
                        File.Delete(File1BackupLocation);
                        File.Copy(File1Location, File1BackupLocation);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\n!!! Nie można wykonać kopii pliku \"Survival.zxcheck\" !!!\n");
                        SystemSounds.Hand.Play();
                    }
                    if (File.Exists(File1BackupLocation))
                    {
                        Console.WriteLine("Kopia pliku \"Survival.zxcheck\" wykonana pomyślnie");
                        SystemSounds.Beep.Play();
                    }
                }
            }
            if (File.Exists(File2Location))
            {
                if (!File.Exists(File2BackupLocation))
                {
                    Console.WriteLine("Wykryto plik \"Survival.zxsav\". Próba wykonania kopii pliku...");
                    try
                    {
                        File.Copy(File2Location, File2BackupLocation);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\n!!! Nie można wykonać kopii pliku \"Survival.zxsav\" !!!\n");
                        SystemSounds.Hand.Play();
                    }
                    if (File.Exists(File2BackupLocation))
                    {
                        Console.WriteLine("Kopia pliku \"Survival.zxsav\" wykonana pomyślnie");
                        SystemSounds.Beep.Play();
                    }
                }
                if (File.GetLastWriteTime(File2Location) != File.GetLastWriteTime(File2BackupLocation))
                {
                    Console.WriteLine("Wykryto zmiany w pliku \"Survival.zxsav\". Próba wykonania kopii pliku...");
                    try
                    {
                        File.Delete(File2BackupLocation);
                        File.Copy(File2Location, File2BackupLocation);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\n!!! Nie można wykonać kopii pliku \"Survival.zxsav\" !!!\n");
                        SystemSounds.Hand.Play();
                    }
                    if (File.Exists(File2BackupLocation))
                    {
                        Console.WriteLine("Kopia pliku \"Survival.zxsav\" wykonana pomyślnie");
                        SystemSounds.Beep.Play();
                    }
                }
            }
            if(!File.Exists(File1Location))
            {
                if(File.Exists(File1BackupLocation))
                {
                    Console.WriteLine("Wykryto usunięcie pliku \"Survival.zxcheck\". Próba przywrócenia kopii pliku...");
                    try
                    {
                        File.Copy(File1BackupLocation, File1Location);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\n!!! Nie można przywrócić pliku \"Survival.zxcheck\" !!!\n");
                        SystemSounds.Hand.Play();
                    }
                    if (File.Exists(File1Location))
                    {
                        Console.WriteLine("Przywrócenie pliku \"Survival.zxcheck\" wykonane pomyślnie. Ty mały oszuście ;-)");
                        SystemSounds.Beep.Play();
                    }
                }
                else
                {
                    Console.WriteLine("Nie wykryto pliku \"Survival.zxcheck\". Brak kopii pliku.");
                    SystemSounds.Hand.Play();
                }
            }
            if (!File.Exists(File2Location))
            {
                if (File.Exists(File2BackupLocation))
                {
                    Console.WriteLine("Wykryto usunięcie pliku \"Survival.zxsav\". Próba przywrócenia kopii pliku...");
                    try
                    {
                        File.Copy(File2BackupLocation, File2Location);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\n!!! Nie można przywrócić pliku \"Survival.zxsav\" !!!\n");
                        SystemSounds.Hand.Play();
                    }
                    if (File.Exists(File2Location))
                    {
                        Console.WriteLine("Przywrócenie pliku \"Survival.zxsav\" wykonane pomyślnie. Ty mały oszuście ;-)");
                        SystemSounds.Beep.Play();
                    }
                }
                else
                {
                    Console.WriteLine("Nie wykryto pliku \"Survival.zxsav\". Brak kopii pliku.");
                    SystemSounds.Hand.Play();
                }
            }
        }
    }
}
