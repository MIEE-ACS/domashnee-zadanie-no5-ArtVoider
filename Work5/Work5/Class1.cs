using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work5
{
    class Game
    {
        private string Name;
        private string Genre;
        private string Multy_user;
        private string Platform;


        public string NAME
        {
            get
            {
                return Name;
            }
            set
            {
                try
                {
                    //foreach (var name in value.Split(' '))
                    //{
                        Name += char.ToUpper(value[0]) + value.Remove(0, 1) + " ";
                    //}
                }
                catch
                {
                    throw new Exception("Введите название игры!");
                }
            }
        }


        public string GENRE
        {
            get
            {
                return Genre;
            }
            set
            {
                try
                {
                    foreach (var name in value.Split(' '))
                    {
                        Genre = char.ToUpper(value[0]) + value.Remove(0, 1);
                    }
                }
                catch
                {
                    throw new Exception("Введите потдерживаемые платформы!");
                }
            }
        }


        public string MULTY
        {
            get
            {
                return Multy_user;
            }
            set
            {
                try
                {

                Multy_user += char.ToUpper(value[0]) + value.Remove(0, 1) + " ";

                }
                catch
                {
                    throw new Exception("Введите тип!");
                }
            }
        
    }
        //Однопользовательская, Многопользовательская

        public string PLATFORM
        {
            get
            {
                return Platform;
            }
            set
            {
                try
                {
                    foreach (var name in value.Split(' '))
                    {
                        Platform = char.ToUpper(value[0]) + value.Remove(0, 1);
                    }
                }
                catch
                {
                    throw new Exception("Введите потдерживаемые платформы!");
                }
            }
        }

        // PC, xboxone, nintendoswitch, Sony



        public override string ToString()
        {
            return $"Название игры: {Name}; Жанры: {Genre}; Потдерживаемые платформы: {Platform}; Тип игры: {Multy_user};";
        }

    }
}

