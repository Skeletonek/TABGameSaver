using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Timers;
using System.Media;

namespace TABGameSaver
{
    #region Copyright
    // Copyright (C) 2019-2021 Skeletonek
    //
    // This program is free software: you can redistribute it and/or modify
    // it under the +terms of the GNU General Public License as published by
    // the Free Software Foundation, either version 3 of the License, or
    // (at your option) any later version.
    //
    // This program is distributed in the hope that it will be useful,
    // but WITHOUT ANY WARRANTY; without even the implied warranty of
    // MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    // GNU General Public License for more details.
    //
    // You should have received a copy of the GNU General Public License
    // along with this program.  If not, see http://www.gnu.org/licenses/. 
    #endregion
    class Program
    {
        static string location = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        static Timer timer = new Timer(5000);
        static string File1Location = Directory.GetCurrentDirectory() + @"\Survival.zxcheck";
        static string File1BackupLocation = Directory.GetCurrentDirectory() + @"\TABGameSaverFiles\Survival.zxcheck";
        static string File2Location = Directory.GetCurrentDirectory() + @"\Survival.zxsav";
        static string File2BackupLocation = Directory.GetCurrentDirectory() + @"\TABGameSaverFiles\Survival.zxsav";
        static string DirectoryLocation = Directory.GetCurrentDirectory() + @"\TABGameSaverFiles";

        static Languages lang = new Languages();
        public static void Main(string[] args)
        {
            timer.Elapsed += TimerElapsed;
            timer.AutoReset = true;
            Console.WriteLine("They Are Billions Game Saver\nVersion: 1.2.0\nAuthor: Skeletonek\nCopyright (C) 2019 - 2021\n\nThis program is licensed under GNU General Public License v3.0\n\n--------------------");
            Console.WriteLine(lang.strData[0]);
            Console.WriteLine(lang.strData[1]);
            Console.WriteLine(lang.strData[2]);
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
                        Console.WriteLine(lang.strData[3]);
                        SystemSounds.Hand.Play();
                        timer.Enabled = false;
                    }
                    if (Directory.Exists(DirectoryLocation))
                    {
                        Console.WriteLine(lang.strData[4]);
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
            Console.WriteLine(lang.strData[5]);
            if (File.Exists(File1Location))
            {
                if (!File.Exists(File1BackupLocation))
                {
                    Console.WriteLine(lang.strData[6] + " \"Survival.zxcheck\". " + lang.strData[7]);
                    try
                    {
                        File.Copy(File1Location, File1BackupLocation);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(lang.strData[8] + " \"Survival.zxcheck\" !!!\n");
                        SystemSounds.Hand.Play();
                    }
                    if (File.Exists(File1BackupLocation))
                    {
                        Console.WriteLine(lang.strData[9] + " \"Survival.zxcheck\" " + lang.strData[10]);
                        SystemSounds.Beep.Play();
                    }
                }
                if (File.GetLastWriteTime(File1Location) != File.GetLastWriteTime(File1BackupLocation))
                {
                    Console.WriteLine(lang.strData[11] + " \"Survival.zxcheck\". " + lang.strData[12]);
                    try
                    {
                        File.Delete(File1BackupLocation);
                        File.Copy(File1Location, File1BackupLocation);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(lang.strData[8] + " \"Survival.zxcheck\" !!!\n");
                        SystemSounds.Hand.Play();
                    }
                    if (File.Exists(File1BackupLocation))
                    {
                        Console.WriteLine(lang.strData[9] + " \"Survival.zxcheck\" " + lang.strData[10]);
                        SystemSounds.Beep.Play();
                    }
                }
            }
            if (File.Exists(File2Location))
            {
                if (!File.Exists(File2BackupLocation))
                {
                    Console.WriteLine(lang.strData[6] + " \"Survival.zxsav\". " + lang.strData[7]);
                    try
                    {
                        File.Copy(File2Location, File2BackupLocation);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(lang.strData[8] + " \"Survival.zxsav\" !!!\n");
                        SystemSounds.Hand.Play();
                    }
                    if (File.Exists(File2BackupLocation))
                    {
                        Console.WriteLine(lang.strData[9] + " \"Survival.zxsav\" " + lang.strData[10]);
                        SystemSounds.Beep.Play();
                    }
                }
                if (File.GetLastWriteTime(File2Location) != File.GetLastWriteTime(File2BackupLocation))
                {
                    Console.WriteLine(lang.strData[11] + " \"Survival.zxsav\". " + lang.strData[12]);
                    try
                    {
                        File.Delete(File2BackupLocation);
                        File.Copy(File2Location, File2BackupLocation);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(lang.strData[8] + " \"Survival.zxsav\" !!!\n");
                        SystemSounds.Hand.Play();
                    }
                    if (File.Exists(File2BackupLocation))
                    {
                        Console.WriteLine(lang.strData[9] + " \"Survival.zxsav\" " + lang.strData[10]);
                        SystemSounds.Beep.Play();
                    }
                }
            }
            if (!File.Exists(File1Location))
            {
                if (File.Exists(File1BackupLocation))
                {
                    Console.WriteLine(lang.strData[13] + " \"Survival.zxcheck\". " + lang.strData[14]);
                    try
                    {
                        File.Copy(File1BackupLocation, File1Location);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(lang.strData[15] + " \"Survival.zxcheck\" !!!\n");
                        SystemSounds.Hand.Play();
                    }
                    if (File.Exists(File1Location))
                    {
                        Console.WriteLine(lang.strData[16] + " \"Survival.zxcheck\" " + lang.strData[17]);
                        SystemSounds.Beep.Play();
                    }
                }
                else
                {
                    Console.WriteLine(lang.strData[18] + " \"Survival.zxcheck\". " + lang.strData[19]);
                }
            }
            if (!File.Exists(File2Location))
            {
                if (File.Exists(File2BackupLocation))
                {
                    Console.WriteLine(lang.strData[13] + " \"Survival.zxsav\". " + lang.strData[14]);
                    try
                    {
                        File.Copy(File2BackupLocation, File2Location);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(lang.strData[15] + " \"Survival.zxsav\" !!!\n");
                        SystemSounds.Hand.Play();
                    }
                    if (File.Exists(File2Location))
                    {
                        Console.WriteLine(lang.strData[16] + " \"Survival.zxsav\" " + lang.strData[17]);
                        SystemSounds.Beep.Play();
                    }
                }
                else
                {
                    Console.WriteLine(lang.strData[18] + " \"Survival.zxsav\". " + lang.strData[19]);
                }
            }
        }
    }
}
