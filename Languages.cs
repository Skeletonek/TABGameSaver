using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace TABGameSaver
{
    #region Copyright
    // Copyright (C) 2019-2021 Skeletonek
    //
    // This program is licensed under GNU General Public License v3.0
    // Full information in Program.cs file
    #endregion
    class Languages
    {
        public string[] strData;
        CultureInfo ci;
        public Languages()
        {
            ci = CultureInfo.InstalledUICulture;
            switch(ci.TwoLetterISOLanguageName)
            {
                case "pl":
                    LoadLanguage_PL();
                    break;

                case "en":
                    LoadLanguage_EN();
                    break;

                default:
                    LoadLanguage_EN();
                    break;
            }
        }
        private void LoadLanguage_PL()
        {
            strData = new string[]
            { 
            "Proszę umieścić plik w katalogu z save'ami do gry They Are Billions\n(Dokumenty\\My Games\\They Are Billions\\Saves)\n", //0
            "Aplikacja wykrywa tylko zapis z domyślną nazwą trybu survival.\nZmiana nazwy zapisu będzie skutkować nie działaniem aplikacji!\n",
            "Czy aplikacja znajduje się w katalogu z zapisami do gry They Are Billions? (Y/N): ",
            "!!! Nie można stworzyć katalogu aplikacji. Program nie będzie dalej kontynuował pracy !!!\n",
            "Utworzono katalog aplikacji.",
            "Sprawdzanie plików...", //5
            "Wykryto plik",
            "Próba wykonania kopii pliku...",
            "\n!!! Nie można wykonać kopii pliku",
            "Kopia pliku",
            "wykonana pomyślnie", //10
            "Wykryto zmiany w pliku",
            "Próba wykonania kopii pliku...",
            "Wykryto usunięcie pliku",
            "Próba przywrócenia kopii pliku...",
            "\n!!! Nie można przywrócić pliku", //15
            "Przywrócenie pliku",
            "wykonane pomyślnie.",
            "Nie wykryto pliku",
            ".Brak kopii pliku.", //19
            };

        }
        private void LoadLanguage_EN()
        {
            strData = new string[] { "Wow" };
        }
    }
}
