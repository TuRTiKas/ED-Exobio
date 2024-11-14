using System.Numerics;

namespace ED_Exobio
{
    internal class Program
    {
        const int value_of_biology = 125;

        static private string type_of_planet;
        static private string atmosphere;
        static private double temperature;
        static private double gravity;
        static private int sector;

        static private string[] info_of_biology_name = new string[value_of_biology];

        static private string[,] info_of_biology_type_of_planet = new string[value_of_biology, 10];

        static private string[,] info_of_biology_atmosphere = new string[value_of_biology, 10];

        static private double[,,] info_of_biology_temperature = new double[value_of_biology, 10, 2];

        static private double[,,] info_of_biology_gravity = new double[value_of_biology, 10, 2];

        static private double[,] info_of_biology_cost = new double[value_of_biology, 2];

        static private int[,,] info_of_biology_support = new int[value_of_biology, 2, 2];

        static private string[] info_of_biology_additional_info = new string[value_of_biology];

        static private bool[] matching = new bool[value_of_biology];
        static public int number_of_biology = 0;

        static public int [,] info_of_biology_sector = new int [value_of_biology,43];

        static public void Init()
        {
            //Мусорный участок кода. Отсюда начинается заполнение информации
            ////////////////////////////////////////////////////////////////////////
            //int number_of_biology = 0;
            info_of_biology_name[number_of_biology] = "Фонтикула Fluctus";

            //0 - Зависимость от типа планеты, 1 - зависимость от атмосферы; 1 - Кол-во возможных
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 1;
            info_of_biology_support[number_of_biology, 1, 1] = 1;

            //[number_of_biology, x]: x добавляется вручную по надобности
            info_of_biology_type_of_planet[number_of_biology, 0] = "Ледяной мир";

            //[number_of_biology, x]: x добавляется вручную по надобности
            info_of_biology_atmosphere[number_of_biology, 0] = "Кислород";

            //[number_of_biology, number_of_relation, x]: x=0 - Нижняя граница температуры, x=1 - Верхняя граница температуры
            info_of_biology_temperature[number_of_biology, 0, 0] = 144.9;
            info_of_biology_temperature[number_of_biology, 0, 1] = 197.1;

            //[number_of_biology, number_of_relation, x]: x=0 - Нижняя граница гравитации, x=1 - Верхняя граница гравитации
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.238;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.275;

            //0 - Цена за открытие, 1 - бонус первооткрывателя
            info_of_biology_cost[number_of_biology, 0] = 20000000;
            info_of_biology_cost[number_of_biology, 1] = 80000000;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 500 м";
            //info_of_biology_sector[number_of_biology, 0] всегда отвечает за количество регионов галактики. Если 0, значит ВСЕ
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            //Пример ввода данных вручную
            /*
            ///////////////////////////////////////////////////////////////////////
            info_of_biology_name[number_of_biology] = "";

            //0 - Зависимость от типа планеты, 1 - зависимость от атмосферы; 1 - Кол-во возможных
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 1;
            info_of_biology_support[number_of_biology, 1, 1] = 1;

            //[number_of_biology, x]: x добавляется вручную по надобности
            info_of_biology_type_of_planet[number_of_biology, 0] = "";

            //[number_of_biology, x]: x добавляется вручную по надобности
            info_of_biology_atmosphere[number_of_biology, 0] = "";

            //[number_of_biology, number_of_relation, x]: x=0 - Нижняя граница температуры, x=1 - Верхняя граница температуры
            info_of_biology_temperature[number_of_biology, 0, 0] = ;
            info_of_biology_temperature[number_of_biology, 0, 1] = ;

            //[number_of_biology, number_of_relation, x]: x=0 - Нижняя граница гравитации, x=1 - Верхняя граница гравитации
            info_of_biology_gravity[number_of_biology, 0, 0] = ;
            info_of_biology_gravity[number_of_biology, 0, 1] = ;

            //0 - Цена за открытие, 1 - бонус первооткрывателя
            info_of_biology_cost[number_of_biology, 0] = ;
            info_of_biology_cost[number_of_biology, 1] = ;
            number_of_biology++;
            ////////////////////////////////////////////////////////////////////////
            */
            info_of_biology_name[number_of_biology] = "Дерновина Stigmasis";
            info_of_biology_support[number_of_biology, 0, 0] = 2;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 2;
            info_of_biology_support[number_of_biology, 1, 1] = 1;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Диоксид серы";
            info_of_biology_temperature[number_of_biology, 0, 0] = 132.1;
            info_of_biology_temperature[number_of_biology, 0, 1] = 166.4;
            info_of_biology_temperature[number_of_biology, 1, 0] = 132.1;
            info_of_biology_temperature[number_of_biology, 1, 1] = 150.5;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.043;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.275;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.269;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.275;
            info_of_biology_cost[number_of_biology, 0] = 19010800;
            info_of_biology_cost[number_of_biology, 1] = 76043200;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 200 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Моллюск Biconcavis";
            info_of_biology_support[number_of_biology, 0, 0] = 2;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 2;
            info_of_biology_support[number_of_biology, 1, 1] = 1;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Азот";
            info_of_biology_temperature[number_of_biology, 0, 0] = 42.9;
            info_of_biology_temperature[number_of_biology, 0, 1] = 50.2;
            info_of_biology_temperature[number_of_biology, 1, 0] = 47.6;
            info_of_biology_temperature[number_of_biology, 1, 1] = 48.6;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.101;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.272;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.149;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.265;
            info_of_biology_cost[number_of_biology, 0] = 19010800;
            info_of_biology_cost[number_of_biology, 1] = 76043200;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 150 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Стратум Tectonicas";
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 8;
            info_of_biology_support[number_of_biology, 0, 1] = 1;
            info_of_biology_support[number_of_biology, 1, 1] = 8;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Аммиак";
            info_of_biology_atmosphere[number_of_biology, 1] = "Аргон";
            info_of_biology_atmosphere[number_of_biology, 2] = "Богатая аргоном";
            info_of_biology_atmosphere[number_of_biology, 3] = "Вода";
            info_of_biology_atmosphere[number_of_biology, 4] = "Диоксид серы";
            info_of_biology_atmosphere[number_of_biology, 5] = "Диоксид углерода";
            info_of_biology_atmosphere[number_of_biology, 6] = "Высокое содержание диоксида углерода";
            info_of_biology_atmosphere[number_of_biology, 7] = "Кислород";
            info_of_biology_temperature[number_of_biology, 0, 0] = 165;
            info_of_biology_temperature[number_of_biology, 0, 1] = 176.2;
            info_of_biology_temperature[number_of_biology, 1, 0] = 173.5;
            info_of_biology_temperature[number_of_biology, 1, 1] = 181.3;
            info_of_biology_temperature[number_of_biology, 2, 0] = 186.5;
            info_of_biology_temperature[number_of_biology, 2, 1] = 187.2;
            info_of_biology_temperature[number_of_biology, 3, 0] = 392.2;
            info_of_biology_temperature[number_of_biology, 3, 1] = 448.2;
            info_of_biology_temperature[number_of_biology, 4, 0] = 165;
            info_of_biology_temperature[number_of_biology, 4, 1] = 449.7;
            info_of_biology_temperature[number_of_biology, 5, 0] = 165;
            info_of_biology_temperature[number_of_biology, 5, 1] = 425.2;
            info_of_biology_temperature[number_of_biology, 6, 0] = 166;
            info_of_biology_temperature[number_of_biology, 6, 1] = 248.7;
            info_of_biology_temperature[number_of_biology, 7, 0] = 165.2;
            info_of_biology_temperature[number_of_biology, 7, 1] = 245.1;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.049;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.374;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.506;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.518;
            info_of_biology_gravity[number_of_biology, 2, 0] = 0.521;
            info_of_biology_gravity[number_of_biology, 2, 1] = 0.523;
            info_of_biology_gravity[number_of_biology, 3, 0] = 0.046;
            info_of_biology_gravity[number_of_biology, 3, 1] = 0.062;
            info_of_biology_gravity[number_of_biology, 4, 0] = 0.293;
            info_of_biology_gravity[number_of_biology, 4, 1] = 0.596;
            info_of_biology_gravity[number_of_biology, 5, 0] = 0.047;
            info_of_biology_gravity[number_of_biology, 5, 1] = 0.6;
            info_of_biology_gravity[number_of_biology, 6, 0] = 0.359;
            info_of_biology_gravity[number_of_biology, 6, 1] = 0.606;
            info_of_biology_gravity[number_of_biology, 7, 0] = 0.404;
            info_of_biology_gravity[number_of_biology, 7, 1] = 0.512;
            info_of_biology_cost[number_of_biology, 0] = 19010800;
            info_of_biology_cost[number_of_biology, 1] = 76043200;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 500 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Фонтикула Segmentatus";
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 1;
            info_of_biology_support[number_of_biology, 1, 1] = 2;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Ледяной мир";
            info_of_biology_atmosphere[number_of_biology, 0] = "Неон";
            info_of_biology_atmosphere[number_of_biology, 1] = "Богатая неоном";
            info_of_biology_temperature[number_of_biology, 0, 0] = 50.9;
            info_of_biology_temperature[number_of_biology, 0, 1] = 68.5;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.252;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.275;
            info_of_biology_cost[number_of_biology, 0] = 19010800;
            info_of_biology_cost[number_of_biology, 1] = 76043200;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 500 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Дымник Extremus";
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 4;
            info_of_biology_support[number_of_biology, 0, 1] = 3;
            info_of_biology_support[number_of_biology, 1, 1] = 4;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменисто-ледяной мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 2] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Аммиак";
            info_of_biology_atmosphere[number_of_biology, 1] = "Аргон";
            info_of_biology_atmosphere[number_of_biology, 2] = "Диоксид серы";
            info_of_biology_atmosphere[number_of_biology, 3] = "Метан";
            info_of_biology_temperature[number_of_biology, 0, 0] = 161.8;
            info_of_biology_temperature[number_of_biology, 0, 1] = 176.6;
            info_of_biology_temperature[number_of_biology, 1, 0] = 56.7;
            info_of_biology_temperature[number_of_biology, 1, 1] = 88.8;
            info_of_biology_temperature[number_of_biology, 2, 0] = 148.2;
            info_of_biology_temperature[number_of_biology, 2, 1] = 166.2;
            info_of_biology_temperature[number_of_biology, 3, 0] = 78.6;
            info_of_biology_temperature[number_of_biology, 3, 1] = 107.3;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.041;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.071;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.079;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.268;
            info_of_biology_gravity[number_of_biology, 2, 0] = 0.264;
            info_of_biology_gravity[number_of_biology, 2, 1] = 0.274;
            info_of_biology_gravity[number_of_biology, 3, 0] = 0.044;
            info_of_biology_gravity[number_of_biology, 3, 1] = 0.127;
            info_of_biology_cost[number_of_biology, 0] = 16202800;
            info_of_biology_cost[number_of_biology, 1] = 64811200;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 100 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Кактусоид Vermis";
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 2;
            info_of_biology_support[number_of_biology, 0, 1] = 2;
            info_of_biology_support[number_of_biology, 1, 1] = 2;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Вода";
            info_of_biology_atmosphere[number_of_biology, 1] = "Диоксид серы";
            info_of_biology_temperature[number_of_biology, 0, 0] = 392.2;
            info_of_biology_temperature[number_of_biology, 0, 1] = 449.9;
            info_of_biology_temperature[number_of_biology, 1, 0] = 163.3;
            info_of_biology_temperature[number_of_biology, 1, 1] = 163.5;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.041;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.063;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.273;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.275;
            info_of_biology_cost[number_of_biology, 0] = 16202800;
            info_of_biology_cost[number_of_biology, 1] = 64811200;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 300 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Клипеус Speculumi";
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 2;
            info_of_biology_support[number_of_biology, 0, 1] = 1;
            info_of_biology_support[number_of_biology, 1, 1] = 2;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_atmosphere[number_of_biology, 0] = "Диоксид углерода";
            info_of_biology_atmosphere[number_of_biology, 1] = "Вода";
            info_of_biology_temperature[number_of_biology, 0, 0] = 190;
            info_of_biology_temperature[number_of_biology, 0, 1] = 195.4;
            info_of_biology_temperature[number_of_biology, 1, 0] = 398.1;
            info_of_biology_temperature[number_of_biology, 1, 1] = 448.6;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.042;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.236;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.042;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.054;
            info_of_biology_cost[number_of_biology, 0] = 16202800;
            info_of_biology_cost[number_of_biology, 1] = 64811200;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 150 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Рецептоид Deltahedronix";
            info_of_biology_support[number_of_biology, 0, 0] = 4;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 4;
            info_of_biology_support[number_of_biology, 1, 1] = 2;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменисто-ледяной мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 2] = "Ледяной мир";
            info_of_biology_type_of_planet[number_of_biology, 3] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Диоксид серы";
            info_of_biology_atmosphere[number_of_biology, 1] = "Диоксид углерода";
            info_of_biology_temperature[number_of_biology, 0, 0] = 152.6;
            info_of_biology_temperature[number_of_biology, 0, 1] = 220.4;
            info_of_biology_temperature[number_of_biology, 1, 0] = 132.1;
            info_of_biology_temperature[number_of_biology, 1, 1] = 194.9;
            info_of_biology_temperature[number_of_biology, 2, 0] = 149.1;
            info_of_biology_temperature[number_of_biology, 2, 1] = 267.5;
            info_of_biology_temperature[number_of_biology, 3, 0] = 132.1;
            info_of_biology_temperature[number_of_biology, 3, 1] = 134.2;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.227;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.272;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.044;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.274;
            info_of_biology_gravity[number_of_biology, 2, 0] = 0.189;
            info_of_biology_gravity[number_of_biology, 2, 1] = 0.027;
            info_of_biology_gravity[number_of_biology, 3, 0] = 0.269;
            info_of_biology_gravity[number_of_biology, 3, 1] = 0.275;
            info_of_biology_cost[number_of_biology, 0] = 16202800;
            info_of_biology_cost[number_of_biology, 1] = 64811200;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 150 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Стратум Cucumisis";
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 4;
            info_of_biology_support[number_of_biology, 0, 1] = 1;
            info_of_biology_support[number_of_biology, 1, 1] = 4;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_atmosphere[number_of_biology, 0] = "Диоксид серы";
            info_of_biology_atmosphere[number_of_biology, 1] = "Диоксид углерода";
            info_of_biology_atmosphere[number_of_biology, 2] = "Высокое содержание диоксида углерода";
            info_of_biology_atmosphere[number_of_biology, 3] = "Кислород";
            info_of_biology_temperature[number_of_biology, 0, 0] = 191;
            info_of_biology_temperature[number_of_biology, 0, 1] = 372.3;
            info_of_biology_temperature[number_of_biology, 1, 0] = 191;
            info_of_biology_temperature[number_of_biology, 1, 1] = 370.8;
            info_of_biology_temperature[number_of_biology, 2, 0] = 225.2;
            info_of_biology_temperature[number_of_biology, 2, 1] = 241.6;
            info_of_biology_temperature[number_of_biology, 3, 0] = 211.8;
            info_of_biology_temperature[number_of_biology, 3, 1] = 234.2;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.295;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.524;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.042;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.586;
            info_of_biology_gravity[number_of_biology, 2, 0] = 0.452;
            info_of_biology_gravity[number_of_biology, 2, 1] = 0.599;
            info_of_biology_gravity[number_of_biology, 3, 0] = 0.429;
            info_of_biology_gravity[number_of_biology, 3, 1] = 0.451;
            info_of_biology_cost[number_of_biology, 0] = 16202800;
            info_of_biology_cost[number_of_biology, 1] = 64811200;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 500 м";
            info_of_biology_sector[number_of_biology, 0] = 10;
            info_of_biology_sector[number_of_biology, 1] = 1;
            info_of_biology_sector[number_of_biology, 2] = 4;
            info_of_biology_sector[number_of_biology, 3] = 9;
            info_of_biology_sector[number_of_biology, 4] = 18;
            info_of_biology_sector[number_of_biology, 5] = 19;
            info_of_biology_sector[number_of_biology, 6] = 20;
            info_of_biology_sector[number_of_biology, 7] = 21;
            info_of_biology_sector[number_of_biology, 8] = 22;
            info_of_biology_sector[number_of_biology, 9] = 23;
            info_of_biology_sector[number_of_biology, 10] = 40;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Дерновина Virgam";
            info_of_biology_support[number_of_biology, 0, 0] = 2;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 2;
            info_of_biology_support[number_of_biology, 1, 1] = 1;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Вода";
            info_of_biology_temperature[number_of_biology, 0, 0] = 394.9;
            info_of_biology_temperature[number_of_biology, 0, 1] = 449.8;
            info_of_biology_temperature[number_of_biology, 1, 0] = 392.2;
            info_of_biology_temperature[number_of_biology, 1, 1] = 449.9;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.04;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.055;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.046;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.063;
            info_of_biology_cost[number_of_biology, 0] = 14313700;
            info_of_biology_cost[number_of_biology, 1] = 57254800;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 200 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Рецептоид Conditivus";
            info_of_biology_support[number_of_biology, 0, 0] = 4;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 4;
            info_of_biology_support[number_of_biology, 1, 1] = 3;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменисто-ледяной мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 2] = "Ледяной мир";
            info_of_biology_type_of_planet[number_of_biology, 3] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Диоксид серы";
            info_of_biology_atmosphere[number_of_biology, 1] = "Диоксид углерода";
            info_of_biology_atmosphere[number_of_biology, 2] = "Кислород";
            info_of_biology_temperature[number_of_biology, 0, 0] = 149.7;
            info_of_biology_temperature[number_of_biology, 0, 1] = 219;
            info_of_biology_temperature[number_of_biology, 1, 0] = 132.1;
            info_of_biology_temperature[number_of_biology, 1, 1] = 188;
            info_of_biology_temperature[number_of_biology, 2, 0] = 145;
            info_of_biology_temperature[number_of_biology, 2, 1] = 269.1;
            info_of_biology_temperature[number_of_biology, 3, 0] = 132.3;
            info_of_biology_temperature[number_of_biology, 3, 1] = 134.3;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.216;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.274;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.051;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.274;
            info_of_biology_gravity[number_of_biology, 2, 0] = 0.193;
            info_of_biology_gravity[number_of_biology, 2, 1] = 0.275;
            info_of_biology_gravity[number_of_biology, 3, 0] = 0.27;
            info_of_biology_gravity[number_of_biology, 3, 1] = 0.274;
            info_of_biology_cost[number_of_biology, 0] = 14313700;
            info_of_biology_cost[number_of_biology, 1] = 57254800;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 150 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Алеоид Gravis";
            info_of_biology_support[number_of_biology, 0, 0] = 2;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 2;
            info_of_biology_support[number_of_biology, 1, 1] = 1;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Диоксид углерода";
            info_of_biology_temperature[number_of_biology, 0, 0] = 190;
            info_of_biology_temperature[number_of_biology, 0, 1] = 195.4;
            info_of_biology_temperature[number_of_biology, 1, 0] = 190;
            info_of_biology_temperature[number_of_biology, 1, 1] = 195.4;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.042;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.237;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.204;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.271;
            info_of_biology_cost[number_of_biology, 0] = 12934900;
            info_of_biology_cost[number_of_biology, 1] = 51739600;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 150 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Оссия Discus";
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 4;
            info_of_biology_support[number_of_biology, 0, 1] = 3;
            info_of_biology_support[number_of_biology, 1, 1] = 4;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменисто-ледяной мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 2] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Аммиак";
            info_of_biology_atmosphere[number_of_biology, 1] = "Аргон";
            info_of_biology_atmosphere[number_of_biology, 2] = "Вода";
            info_of_biology_atmosphere[number_of_biology, 3] = "Метан";
            info_of_biology_temperature[number_of_biology, 0, 0] = 165.6;
            info_of_biology_temperature[number_of_biology, 0, 1] = 176.6;
            info_of_biology_temperature[number_of_biology, 1, 0] = 81.2;
            info_of_biology_temperature[number_of_biology, 1, 1] = 107.1;
            info_of_biology_temperature[number_of_biology, 2, 0] = 394.4;
            info_of_biology_temperature[number_of_biology, 2, 1] = 451.6;
            info_of_biology_temperature[number_of_biology, 3, 0] = 79.1;
            info_of_biology_temperature[number_of_biology, 3, 1] = 107.3;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.037;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.087;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.227;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.268;
            info_of_biology_gravity[number_of_biology, 2, 0] = 0.04;
            info_of_biology_gravity[number_of_biology, 2, 1] = 0.062;
            info_of_biology_gravity[number_of_biology, 3, 0] = 0.044;
            info_of_biology_gravity[number_of_biology, 3, 1] = 0.127;
            info_of_biology_cost[number_of_biology, 0] = 12934900;
            info_of_biology_cost[number_of_biology, 1] = 51739600;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 800 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Рецепотид Umbrux";
            info_of_biology_support[number_of_biology, 0, 0] = 4;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 4;
            info_of_biology_support[number_of_biology, 1, 1] = 3;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменисто-ледяной мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 2] = "Ледяной мир";
            info_of_biology_type_of_planet[number_of_biology, 3] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Диоксид серы";
            info_of_biology_atmosphere[number_of_biology, 1] = "Диоксид углерода";
            info_of_biology_atmosphere[number_of_biology, 2] = "Кислород";
            info_of_biology_temperature[number_of_biology, 0, 0] = 147.8;
            info_of_biology_temperature[number_of_biology, 0, 1] = 225.5;
            info_of_biology_temperature[number_of_biology, 1, 0] = 132;
            info_of_biology_temperature[number_of_biology, 1, 1] = 210.3;
            info_of_biology_temperature[number_of_biology, 2, 0] = 145.6;
            info_of_biology_temperature[number_of_biology, 2, 1] = 271;
            info_of_biology_temperature[number_of_biology, 3, 0] = 132.1;
            info_of_biology_temperature[number_of_biology, 3, 1] = 134.3;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.22;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.275;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.043;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.274;
            info_of_biology_gravity[number_of_biology, 2, 0] = 0.188;
            info_of_biology_gravity[number_of_biology, 2, 1] = 0.275;
            info_of_biology_gravity[number_of_biology, 3, 0] = 0.269;
            info_of_biology_gravity[number_of_biology, 3, 1] = 0.275;
            info_of_biology_cost[number_of_biology, 0] = 12934900;
            info_of_biology_cost[number_of_biology, 1] = 51739600;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 150 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Клипеус Margaritus";
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 2;
            info_of_biology_support[number_of_biology, 0, 1] = 1;
            info_of_biology_support[number_of_biology, 1, 1] = 2;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Диоксид углерода";
            info_of_biology_atmosphere[number_of_biology, 1] = "Вода";
            info_of_biology_temperature[number_of_biology, 0, 0] = 190;
            info_of_biology_temperature[number_of_biology, 0, 1] = 195.4;
            info_of_biology_temperature[number_of_biology, 1, 0] = 392.3;
            info_of_biology_temperature[number_of_biology, 1, 1] = 449.9;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.083;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.271;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.046;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.063;
            info_of_biology_cost[number_of_biology, 0] = 11873200;
            info_of_biology_cost[number_of_biology, 1] = 47492800;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 150 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Тубус Cavas";
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 1;
            info_of_biology_support[number_of_biology, 1, 1] = 1;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_atmosphere[number_of_biology, 0] = "Диоксид углерода";
            info_of_biology_temperature[number_of_biology, 0, 0] = 160;
            info_of_biology_temperature[number_of_biology, 0, 1] = 194.7;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.041;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.151;
            info_of_biology_cost[number_of_biology, 0] = 11873200;
            info_of_biology_cost[number_of_biology, 1] = 47492800;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 800 м";
            info_of_biology_sector[number_of_biology, 0] = 11;
            info_of_biology_sector[number_of_biology, 1] = 1;
            info_of_biology_sector[number_of_biology, 2] = 4;
            info_of_biology_sector[number_of_biology, 3] = 9;
            info_of_biology_sector[number_of_biology, 4] = 10;
            info_of_biology_sector[number_of_biology, 5] = 11;
            info_of_biology_sector[number_of_biology, 6] = 12;
            info_of_biology_sector[number_of_biology, 7] = 24;
            info_of_biology_sector[number_of_biology, 8] = 25;
            info_of_biology_sector[number_of_biology, 9] = 26;
            info_of_biology_sector[number_of_biology, 10] = 28;
            info_of_biology_sector[number_of_biology, 11] = 42;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Кустарник Flammasis";
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 1;
            info_of_biology_support[number_of_biology, 1, 1] = 1;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_atmosphere[number_of_biology, 0] = "Аммиак";
            info_of_biology_temperature[number_of_biology, 0, 0] = 152.3;
            info_of_biology_temperature[number_of_biology, 0, 1] = 176.4;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.041;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.275;
            info_of_biology_cost[number_of_biology, 0] = 10326000;
            info_of_biology_cost[number_of_biology, 1] = 41304000;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 150 м";
            info_of_biology_sector[number_of_biology, 0] = 11;
            info_of_biology_sector[number_of_biology, 1] = 1;
            info_of_biology_sector[number_of_biology, 2] = 4;
            info_of_biology_sector[number_of_biology, 3] = 9;
            info_of_biology_sector[number_of_biology, 4] = 10;
            info_of_biology_sector[number_of_biology, 5] = 11;
            info_of_biology_sector[number_of_biology, 6] = 12;
            info_of_biology_sector[number_of_biology, 7] = 24;
            info_of_biology_sector[number_of_biology, 8] = 25;
            info_of_biology_sector[number_of_biology, 9] = 26;
            info_of_biology_sector[number_of_biology, 10] = 28;
            info_of_biology_sector[number_of_biology, 11] = 42;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Оссия Pellebantus";
            info_of_biology_support[number_of_biology, 0, 0] = 2;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 2;
            info_of_biology_support[number_of_biology, 1, 1] = 1;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Диоксид углерода";
            info_of_biology_temperature[number_of_biology, 0, 0] = 191;
            info_of_biology_temperature[number_of_biology, 0, 1] = 196.1;
            info_of_biology_temperature[number_of_biology, 1, 0] = 191;
            info_of_biology_temperature[number_of_biology, 1, 1] = 195.4;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.042;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.236;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.083;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.27;
            info_of_biology_cost[number_of_biology, 0] = 9739000;
            info_of_biology_cost[number_of_biology, 1] = 38956000;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 800 м";
            info_of_biology_sector[number_of_biology, 0] = 30;
            info_of_biology_sector[number_of_biology, 1] = 2;
            info_of_biology_sector[number_of_biology, 2] = 4;
            info_of_biology_sector[number_of_biology, 3] = 5;
            info_of_biology_sector[number_of_biology, 4] = 6;
            info_of_biology_sector[number_of_biology, 5] = 8;
            info_of_biology_sector[number_of_biology, 6] = 9;
            info_of_biology_sector[number_of_biology, 7] = 10;
            info_of_biology_sector[number_of_biology, 8] = 11;
            info_of_biology_sector[number_of_biology, 9] = 12;
            info_of_biology_sector[number_of_biology, 10] = 13;
            info_of_biology_sector[number_of_biology, 11] = 14;
            info_of_biology_sector[number_of_biology, 12] = 16;
            info_of_biology_sector[number_of_biology, 13] = 17;
            info_of_biology_sector[number_of_biology, 14] = 18;
            info_of_biology_sector[number_of_biology, 15] = 19;
            info_of_biology_sector[number_of_biology, 16] = 20;
            info_of_biology_sector[number_of_biology, 17] = 21;
            info_of_biology_sector[number_of_biology, 18] = 22;
            info_of_biology_sector[number_of_biology, 19] = 23;
            info_of_biology_sector[number_of_biology, 20] = 24;
            info_of_biology_sector[number_of_biology, 21] = 25;
            info_of_biology_sector[number_of_biology, 22] = 26;
            info_of_biology_sector[number_of_biology, 23] = 27;
            info_of_biology_sector[number_of_biology, 24] = 28;
            info_of_biology_sector[number_of_biology, 25] = 29;
            info_of_biology_sector[number_of_biology, 26] = 31;
            info_of_biology_sector[number_of_biology, 27] = 35;
            info_of_biology_sector[number_of_biology, 28] = 37;
            info_of_biology_sector[number_of_biology, 29] = 40;
            info_of_biology_sector[number_of_biology, 30] = 41;
            info_of_biology_sector[number_of_biology, 31] = 42;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Бактерия Informem";
            info_of_biology_support[number_of_biology, 0, 0] = 4;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 4;
            info_of_biology_support[number_of_biology, 1, 1] = 1;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменисто-ледяной мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 2] = "Ледяной мир";
            info_of_biology_type_of_planet[number_of_biology, 3] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Азот";
            info_of_biology_temperature[number_of_biology, 0, 0] = 50.2;
            info_of_biology_temperature[number_of_biology, 0, 1] = 80.8;
            info_of_biology_temperature[number_of_biology, 1, 0] = 43.6;
            info_of_biology_temperature[number_of_biology, 1, 1] = 146.5;
            info_of_biology_temperature[number_of_biology, 2, 0] = 50;
            info_of_biology_temperature[number_of_biology, 2, 1] = 81.8;
            info_of_biology_temperature[number_of_biology, 3, 0] = 47.6;
            info_of_biology_temperature[number_of_biology, 3, 1] = 149;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.231;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.430;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.128;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.52;
            info_of_biology_gravity[number_of_biology, 2, 0] = 0.19;
            info_of_biology_gravity[number_of_biology, 2, 1] = 0.402;
            info_of_biology_gravity[number_of_biology, 3, 0] = 0.265;
            info_of_biology_gravity[number_of_biology, 3, 1] = 0.591;
            info_of_biology_cost[number_of_biology, 0] = 8418000;
            info_of_biology_cost[number_of_biology, 1] = 33672000;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 500 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Клипеус Lacrimam";
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 2;
            info_of_biology_support[number_of_biology, 0, 1] = 1;
            info_of_biology_support[number_of_biology, 1, 1] = 2;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_atmosphere[number_of_biology, 0] = "Диоксид углерода";
            info_of_biology_atmosphere[number_of_biology, 1] = "Вода";
            info_of_biology_temperature[number_of_biology, 0, 0] = 190;
            info_of_biology_temperature[number_of_biology, 0, 1] = 196.1;
            info_of_biology_temperature[number_of_biology, 1, 0] = 394.9;
            info_of_biology_temperature[number_of_biology, 1, 1] = 452;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.042;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.237;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.041;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.055;
            info_of_biology_cost[number_of_biology, 0] = 8418000;
            info_of_biology_cost[number_of_biology, 1] = 33672000;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 150 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Бактерия Volu";
            info_of_biology_support[number_of_biology, 0, 0] = 4;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 4;
            info_of_biology_support[number_of_biology, 1, 1] = 1;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменисто-ледяной мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 2] = "Ледяной мир";
            info_of_biology_type_of_planet[number_of_biology, 3] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Кислород";
            info_of_biology_temperature[number_of_biology, 0, 0] = 153.4;
            info_of_biology_temperature[number_of_biology, 0, 1] = 227.2;
            info_of_biology_temperature[number_of_biology, 1, 0] = 155.5;
            info_of_biology_temperature[number_of_biology, 1, 1] = 244;
            info_of_biology_temperature[number_of_biology, 2, 0] = 144.9;
            info_of_biology_temperature[number_of_biology, 2, 1] = 235.2;
            info_of_biology_temperature[number_of_biology, 3, 0] = 156;
            info_of_biology_temperature[number_of_biology, 3, 1] = 245.1;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.298;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.454;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.394;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.46;
            info_of_biology_gravity[number_of_biology, 2, 0] = 0.24;
            info_of_biology_gravity[number_of_biology, 2, 1] = 0.421;
            info_of_biology_gravity[number_of_biology, 3, 0] = 0.401;
            info_of_biology_gravity[number_of_biology, 3, 1] = 0.512;
            info_of_biology_cost[number_of_biology, 0] = 7774700;
            info_of_biology_cost[number_of_biology, 1] = 31098800;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 500 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Дерновина Triticum";
            info_of_biology_support[number_of_biology, 0, 0] = 2;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 2;
            info_of_biology_support[number_of_biology, 1, 1] = 1;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Диоксид углерода";
            info_of_biology_temperature[number_of_biology, 0, 0] = 191;
            info_of_biology_temperature[number_of_biology, 0, 1] = 195.4;
            info_of_biology_temperature[number_of_biology, 1, 0] = 191;
            info_of_biology_temperature[number_of_biology, 1, 1] = 195.4;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.042;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.236;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.208;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.271;
            info_of_biology_cost[number_of_biology, 0] = 7774700;
            info_of_biology_cost[number_of_biology, 1] = 31098800;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 200 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Кустарник Acus";
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 1;
            info_of_biology_support[number_of_biology, 1, 1] = 1;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_atmosphere[number_of_biology, 0] = "Диоксид углерода";
            info_of_biology_temperature[number_of_biology, 0, 0] = 146.5;
            info_of_biology_temperature[number_of_biology, 0, 1] = 195.4;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.04;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.236;
            info_of_biology_cost[number_of_biology, 0] = 7774700;
            info_of_biology_cost[number_of_biology, 1] = 31098800;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 150 м";
            info_of_biology_sector[number_of_biology, 0] = 8;
            info_of_biology_sector[number_of_biology, 1] = 1;
            info_of_biology_sector[number_of_biology, 2] = 4;
            info_of_biology_sector[number_of_biology, 3] = 7;
            info_of_biology_sector[number_of_biology, 4] = 8;
            info_of_biology_sector[number_of_biology, 5] = 16;
            info_of_biology_sector[number_of_biology, 6] = 17;
            info_of_biology_sector[number_of_biology, 7] = 18;
            info_of_biology_sector[number_of_biology, 8] = 35;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Моллюск Aureolas";
            info_of_biology_support[number_of_biology, 0, 0] = 2;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 2;
            info_of_biology_support[number_of_biology, 1, 1] = 1;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Аммиак";
            info_of_biology_temperature[number_of_biology, 0, 0] = 152.3;
            info_of_biology_temperature[number_of_biology, 0, 1] = 176.6;
            info_of_biology_temperature[number_of_biology, 1, 0] = 156.8;
            info_of_biology_temperature[number_of_biology, 1, 1] = 175.3;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.041;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.274;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.045;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.265;
            info_of_biology_cost[number_of_biology, 0] = 7774700;
            info_of_biology_cost[number_of_biology, 1] = 31098800;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 150 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Тубус Compagibus";
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 1;
            info_of_biology_support[number_of_biology, 1, 1] = 1;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_atmosphere[number_of_biology, 0] = "Диоксид углерода";
            info_of_biology_temperature[number_of_biology, 0, 0] = 160;
            info_of_biology_temperature[number_of_biology, 0, 1] = 196.1;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.042;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.153;
            info_of_biology_cost[number_of_biology, 0] = 7774700;
            info_of_biology_cost[number_of_biology, 1] = 31098800;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 800 м";
            info_of_biology_sector[number_of_biology, 0] = 11;
            info_of_biology_sector[number_of_biology, 1] = 1;
            info_of_biology_sector[number_of_biology, 2] = 4;
            info_of_biology_sector[number_of_biology, 3] = 9;
            info_of_biology_sector[number_of_biology, 4] = 18;
            info_of_biology_sector[number_of_biology, 5] = 19;
            info_of_biology_sector[number_of_biology, 6] = 20;
            info_of_biology_sector[number_of_biology, 7] = 21;
            info_of_biology_sector[number_of_biology, 8] = 22;
            info_of_biology_sector[number_of_biology, 9] = 23;
            info_of_biology_sector[number_of_biology, 10] = 24;
            info_of_biology_sector[number_of_biology, 11] = 40;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Дымник Nitris";
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 6;
            info_of_biology_support[number_of_biology, 0, 1] = 1;
            info_of_biology_support[number_of_biology, 1, 1] = 6;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Ледяной мир";
            info_of_biology_atmosphere[number_of_biology, 0] = "Азот";
            info_of_biology_atmosphere[number_of_biology, 1] = "Аргон";
            info_of_biology_atmosphere[number_of_biology, 2] = "Богатая неоном";
            info_of_biology_atmosphere[number_of_biology, 3] = "Диоксид серы";
            info_of_biology_atmosphere[number_of_biology, 4] = "Кислород";
            info_of_biology_atmosphere[number_of_biology, 5] = "Метан";
            info_of_biology_temperature[number_of_biology, 0, 0] = 77.6;
            info_of_biology_temperature[number_of_biology, 0, 1] = 79.6;
            info_of_biology_temperature[number_of_biology, 1, 0] = 50.2;
            info_of_biology_temperature[number_of_biology, 1, 1] = 140.6;
            info_of_biology_temperature[number_of_biology, 2, 0] = 60.9;
            info_of_biology_temperature[number_of_biology, 2, 1] = 66.5;
            info_of_biology_temperature[number_of_biology, 3, 0] = 191;
            info_of_biology_temperature[number_of_biology, 3, 1] = 218.1;
            info_of_biology_temperature[number_of_biology, 4, 0] = 154.4;
            info_of_biology_temperature[number_of_biology, 4, 1] = 154.4;
            info_of_biology_temperature[number_of_biology, 5, 0] = 83.6;
            info_of_biology_temperature[number_of_biology, 5, 1] = 108.1;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.247;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.253;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.046;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.273;
            info_of_biology_gravity[number_of_biology, 2, 0] = 0.264;
            info_of_biology_gravity[number_of_biology, 2, 1] = 0.265;
            info_of_biology_gravity[number_of_biology, 3, 0] = 0.213;
            info_of_biology_gravity[number_of_biology, 3, 1] = 0.257;
            info_of_biology_gravity[number_of_biology, 4, 0] = 0.267;
            info_of_biology_gravity[number_of_biology, 4, 1] = 0.267;
            info_of_biology_gravity[number_of_biology, 5, 0] = 0.026;
            info_of_biology_gravity[number_of_biology, 5, 1] = 0.045;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 100 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            info_of_biology_cost[number_of_biology, 0] = 7500900;
            info_of_biology_cost[number_of_biology, 1] = 30003600;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Алеоид Arcus";
            info_of_biology_support[number_of_biology, 0, 0] = 2;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 2;
            info_of_biology_support[number_of_biology, 1, 1] = 1;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Мир с высоким содержанием металлов";
            info_of_biology_atmosphere[number_of_biology, 0] = "Диоксид углерода";
            info_of_biology_temperature[number_of_biology, 0, 0] = 175;
            info_of_biology_temperature[number_of_biology, 0, 1] = 180;
            info_of_biology_temperature[number_of_biology, 1, 0] = 175;
            info_of_biology_temperature[number_of_biology, 1, 1] = 180;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.042;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.232;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.112;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.264;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 150 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            info_of_biology_cost[number_of_biology, 0] = 7252500;
            info_of_biology_cost[number_of_biology, 1] = 29010000;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Дерновина Capillum";
            info_of_biology_support[number_of_biology, 0, 0] = 2;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 2;
            info_of_biology_support[number_of_biology, 1, 1] = 2;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Каменисто-ледяной мир";
            info_of_biology_atmosphere[number_of_biology, 0] = "Аргон";
            info_of_biology_atmosphere[number_of_biology, 1] = "Метан";
            info_of_biology_temperature[number_of_biology, 0, 0] = 80.2;
            info_of_biology_temperature[number_of_biology, 0, 1] = 108.4;
            info_of_biology_temperature[number_of_biology, 1, 0] = 80;
            info_of_biology_temperature[number_of_biology, 1, 1] = 127.1;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.05;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.274;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.034;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.275;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 200 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            info_of_biology_cost[number_of_biology, 0] = 7025800;
            info_of_biology_cost[number_of_biology, 1] = 28103200;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Алеоид Coronamus";
            info_of_biology_support[number_of_biology, 0, 0] = 3;
            info_of_biology_support[number_of_biology, 1, 0] = 0;
            info_of_biology_support[number_of_biology, 0, 1] = 3;
            info_of_biology_support[number_of_biology, 1, 1] = 2;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Мир с высоким содержанием металлов";
            info_of_biology_type_of_planet[number_of_biology, 2] = "Ледяной мир";
            info_of_biology_atmosphere[number_of_biology, 0] = "Диоксид углерода";
            info_of_biology_atmosphere[number_of_biology, 1] = "Богатая аргоном";
            info_of_biology_temperature[number_of_biology, 0, 0] = 180;
            info_of_biology_temperature[number_of_biology, 0, 1] = 190;
            info_of_biology_temperature[number_of_biology, 1, 0] = 180;
            info_of_biology_temperature[number_of_biology, 1, 1] = 190;
            info_of_biology_temperature[number_of_biology, 2, 0] = 84.9;
            info_of_biology_temperature[number_of_biology, 2, 1] = 85.1;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.042;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.237;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.052;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.267;
            info_of_biology_gravity[number_of_biology, 2, 0] = 0.292;
            info_of_biology_gravity[number_of_biology, 2, 1] = 0.294;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 150 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            info_of_biology_cost[number_of_biology, 0] = 6284600;
            info_of_biology_cost[number_of_biology, 1] = 25138400;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Дымник Aquatis";
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 9;
            info_of_biology_support[number_of_biology, 0, 1] = 3;
            info_of_biology_support[number_of_biology, 1, 1] = 9;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменисто-ледяной мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Каменистый мир";
            info_of_biology_type_of_planet[number_of_biology, 2] = "Ледяной мир";
            info_of_biology_atmosphere[number_of_biology, 0] = "Азот";
            info_of_biology_atmosphere[number_of_biology, 1] = "Аммиак";
            info_of_biology_atmosphere[number_of_biology, 2] = "Аргон";
            info_of_biology_atmosphere[number_of_biology, 3] = "Богатая аргоном";
            info_of_biology_atmosphere[number_of_biology, 4] = "Вода";
            info_of_biology_atmosphere[number_of_biology, 5] = "Диоксид серы";
            info_of_biology_atmosphere[number_of_biology, 6] = "Кислород";
            info_of_biology_atmosphere[number_of_biology, 7] = "Метан";
            info_of_biology_atmosphere[number_of_biology, 8] = "Неон";
            info_of_biology_temperature[number_of_biology, 0, 0] = 56;
            info_of_biology_temperature[number_of_biology, 0, 1] = 78.8;
            info_of_biology_temperature[number_of_biology, 1, 0] = 164.3;
            info_of_biology_temperature[number_of_biology, 1, 1] = 176;
            info_of_biology_temperature[number_of_biology, 2, 0] = 57.4;
            info_of_biology_temperature[number_of_biology, 2, 1] = 146.6;
            info_of_biology_temperature[number_of_biology, 3, 0] = 86.8;
            info_of_biology_temperature[number_of_biology, 3, 1] = 89.6;
            info_of_biology_temperature[number_of_biology, 4, 0] = 406.1;
            info_of_biology_temperature[number_of_biology, 4, 1] = 446.5;
            info_of_biology_temperature[number_of_biology, 5, 0] = 150.8;
            info_of_biology_temperature[number_of_biology, 5, 1] = 267.5;
            info_of_biology_temperature[number_of_biology, 6, 0] = 154.7;
            info_of_biology_temperature[number_of_biology, 6, 1] = 176.3;
            info_of_biology_temperature[number_of_biology, 7, 0] = 84.1;
            info_of_biology_temperature[number_of_biology, 7, 1] = 92.2;
            info_of_biology_temperature[number_of_biology, 8, 0] = 19.9;
            info_of_biology_temperature[number_of_biology, 8, 1] = 20.1;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.196;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.243;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.029;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.247;
            info_of_biology_gravity[number_of_biology, 2, 0] = 0.167;
            info_of_biology_gravity[number_of_biology, 2, 1] = 0.272;
            info_of_biology_gravity[number_of_biology, 3, 0] = 0.242;
            info_of_biology_gravity[number_of_biology, 3, 1] = 0.261;
            info_of_biology_gravity[number_of_biology, 4, 0] = 0.043;
            info_of_biology_gravity[number_of_biology, 4, 1] = 0.055;
            info_of_biology_gravity[number_of_biology, 5, 0] = 0.184;
            info_of_biology_gravity[number_of_biology, 5, 1] = 0.272;
            info_of_biology_gravity[number_of_biology, 6, 0] = 0.243;
            info_of_biology_gravity[number_of_biology, 6, 1] = 0.274;
            info_of_biology_gravity[number_of_biology, 7, 0] = 0.057;
            info_of_biology_gravity[number_of_biology, 7, 1] = 0.078;
            info_of_biology_gravity[number_of_biology, 8, 0] = 0.268;
            info_of_biology_gravity[number_of_biology, 8, 1] = 0.27;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 100 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            info_of_biology_cost[number_of_biology, 0] = 6284600;
            info_of_biology_cost[number_of_biology, 1] = 25138400;
            number_of_biology++;

            info_of_biology_name[number_of_biology] = "Дымник Carbosis";
            info_of_biology_support[number_of_biology, 0, 0] = 0;
            info_of_biology_support[number_of_biology, 1, 0] = 7;
            info_of_biology_support[number_of_biology, 0, 1] = 2;
            info_of_biology_support[number_of_biology, 1, 1] = 7;
            info_of_biology_type_of_planet[number_of_biology, 0] = "Каменисто-ледяной мир";
            info_of_biology_type_of_planet[number_of_biology, 1] = "Ледяной мир";
            info_of_biology_atmosphere[number_of_biology, 0] = "Азот";
            info_of_biology_atmosphere[number_of_biology, 1] = "Аргон";
            info_of_biology_atmosphere[number_of_biology, 2] = "Богатая аргоном";
            info_of_biology_atmosphere[number_of_biology, 3] = "Диоксид серы";
            info_of_biology_atmosphere[number_of_biology, 4] = "Кислород";
            info_of_biology_atmosphere[number_of_biology, 5] = "Метан";
            info_of_biology_atmosphere[number_of_biology, 6] = "Неон";
            info_of_biology_temperature[number_of_biology, 0, 0] = 58.7;
            info_of_biology_temperature[number_of_biology, 0, 1] = 68.7;
            info_of_biology_temperature[number_of_biology, 1, 0] = 58.1;
            info_of_biology_temperature[number_of_biology, 1, 1] = 139.6;
            info_of_biology_temperature[number_of_biology, 2, 0] = 82;
            info_of_biology_temperature[number_of_biology, 2, 1] = 82.2;
            info_of_biology_temperature[number_of_biology, 3, 0] = 149.1;
            info_of_biology_temperature[number_of_biology, 3, 1] = 269.7;
            info_of_biology_temperature[number_of_biology, 4, 0] = 167.1;
            info_of_biology_temperature[number_of_biology, 4, 1] = 176.8;
            info_of_biology_temperature[number_of_biology, 5, 0] = 84.8;
            info_of_biology_temperature[number_of_biology, 5, 1] = 107.4;
            info_of_biology_temperature[number_of_biology, 6, 0] = 40.5;
            info_of_biology_temperature[number_of_biology, 6, 1] = 40.7;
            info_of_biology_gravity[number_of_biology, 0, 0] = 0.209;
            info_of_biology_gravity[number_of_biology, 0, 1] = 0.242;
            info_of_biology_gravity[number_of_biology, 1, 0] = 0.169;
            info_of_biology_gravity[number_of_biology, 1, 1] = 0.26;
            info_of_biology_gravity[number_of_biology, 2, 0] = 0.240;
            info_of_biology_gravity[number_of_biology, 2, 1] = 0.242;
            info_of_biology_gravity[number_of_biology, 3, 0] = 0.191;
            info_of_biology_gravity[number_of_biology, 3, 1] = 0.266;
            info_of_biology_gravity[number_of_biology, 4, 0] = 0.27;
            info_of_biology_gravity[number_of_biology, 4, 1] = 0.273;
            info_of_biology_gravity[number_of_biology, 5, 0] = 0.026;
            info_of_biology_gravity[number_of_biology, 5, 1] = 0.045;
            info_of_biology_gravity[number_of_biology, 6, 0] = 0.27;
            info_of_biology_gravity[number_of_biology, 6, 1] = 0.272;
            info_of_biology_additional_info[number_of_biology] = "Протяжённость колонии: 100 м";
            info_of_biology_sector[number_of_biology, 0] = 0;
            info_of_biology_cost[number_of_biology, 0] = 6284600;
            info_of_biology_cost[number_of_biology, 1] = 25138400;
            number_of_biology++;


        }

        static public void get_values(string type, string atmo, double temp, double grav)
        {
            type_of_planet = type;
            atmosphere = atmo;
            temperature = temp;
            gravity = grav;
        }

        static public void get_value_type_of_planet(string type)
        {
            type_of_planet = type;
        }

        static public void get_value_type_of_atmosphere(string atmo)
        {
            atmosphere = atmo;
        }

        static public void get_value_temperature(double temp)
        {
            temperature = temp;
        }

        static public void get_value_gravity(double grav)
        {
            gravity = grav;
        }

        static public void get_value_sector(int sect)
        {
            sector = sect;
        }

        static public void new_search()
        {
            for (int j = 0; j<125;j++)
            {
                matching[j] = false;
            }
        }

        static public void process(int i)
        {
            int x1 = 0;
            int x2 = 0;
            do
            {
                if (type_of_planet == info_of_biology_type_of_planet[i, x1])
                {
                    do
                    {
                        if (atmosphere == info_of_biology_atmosphere[i, x2])
                        {
                            if ((info_of_biology_temperature[i, x2, 0] <= temperature && info_of_biology_temperature[i, x2, 1] >= temperature && info_of_biology_support[i, 1, 0] > 0) || (info_of_biology_temperature[i, x1, 0] <= temperature && info_of_biology_temperature[i, x1, 1] >= temperature && info_of_biology_support[i, 0, 0] > 0))
                            {
                                if ((info_of_biology_gravity[i, x2, 0] <= gravity && info_of_biology_gravity[i, x2, 1] >= gravity && info_of_biology_support[i, 1, 0] > 0) || (info_of_biology_gravity[i, x1, 0] <= gravity && info_of_biology_gravity[i, x1, 1] >= gravity && info_of_biology_support[i, 0, 0] > 0))
                                {
                                    matching[i] = true;
                                }
                            }
                            else if (info_of_biology_support[i, 0, 0] == 0 && info_of_biology_support[i, 1, 0] == 0 && (info_of_biology_temperature[i, 0, 0] <= temperature && info_of_biology_temperature[i, 0, 1] >= temperature)&& info_of_biology_gravity[i, 0, 0] <= gravity && info_of_biology_gravity[i, 0, 1] >= gravity)
                            {
                                matching[i] = true;
                            }
                        }
                        x2++;
                    } while (x2 < info_of_biology_support[i, 1, 1]);
                }
                x1++;
                x2 = 0;
            } while (x1 < info_of_biology_support[i, 0, 1]);
        }

        static public string output(int i)
        {
            string output_text = "Название вида: " + Convert.ToString(info_of_biology_name[i]);
            int supscore = 0;
            output_text = output_text + "\nТипы планет: ";
            do
            {
                output_text = output_text + "\n" + info_of_biology_type_of_planet[i, supscore];
                supscore++;
            } while (supscore < info_of_biology_support[i,0,1]);
            supscore = 0;
            output_text = output_text + "\nТипы атмосфер: ";
            do
            {
                output_text = output_text + "\n" + info_of_biology_atmosphere[i, supscore];
                supscore++;
            } while (supscore < info_of_biology_support[i, 1, 1]);
            supscore = 0;
            output_text = output_text + "\nТемпература: ";
            if (info_of_biology_support[i, 0, 0] != 0)
            {
                do
                {
                    output_text = output_text + "\n" + info_of_biology_temperature[i, supscore, 0] + "..." + info_of_biology_temperature[i, supscore, 1] + "К (" + info_of_biology_type_of_planet[i, supscore] + ")";
                    supscore++;
                } while (supscore < info_of_biology_support[i, 0, 0]);
                supscore = 0;
                output_text = output_text + "\nГравитация: ";
                do
                {
                    output_text = output_text + "\n" + info_of_biology_gravity[i, supscore, 0] + "..." + info_of_biology_gravity[i, supscore, 1] + "G (" + info_of_biology_type_of_planet[i, supscore] + ")";
                    supscore++;
                } while (supscore < info_of_biology_support[i, 0, 0]);
            }
            else if (info_of_biology_support[i, 1, 0] != 0)
            {
                do
                {
                    output_text = output_text + "\n" + info_of_biology_temperature[i, supscore, 0] + "..." + info_of_biology_temperature[i, supscore, 1] + "К (" + info_of_biology_atmosphere[i, supscore] + ")";
                    supscore++;
                } while (supscore < info_of_biology_support[i, 1, 0]);
                supscore = 0;
                output_text = output_text + "\nГравитация: ";
                do
                {
                    output_text = output_text + "\n" + info_of_biology_gravity[i, supscore, 0] + "..." + info_of_biology_gravity[i, supscore, 1] + "G (" + info_of_biology_atmosphere[i, supscore] + ")";
                    supscore++;
                } while (supscore < info_of_biology_support[i, 1, 0]);
            }
            else
            {
                output_text = output_text + "\n" + info_of_biology_temperature[i, 0, 0] + "..." + info_of_biology_temperature[i, 0, 1] + "К";
                output_text = output_text + "\nГравитация: ";
                output_text = output_text + "\n" + info_of_biology_gravity[i, 0, 0] + "..." + info_of_biology_gravity[i, 0, 1] + "G";
            }
            output_text = output_text + "\nСтоимость изучения: " + info_of_biology_cost[i, 0].ToString("#,#") + " Кредитов.\nСтоимость первооктрытия: " + (info_of_biology_cost[i, 1]).ToString("#,#") + " Кредитов.\nОбщая стоимость: "
                + (info_of_biology_cost[i, 0] + info_of_biology_cost[i, 1]).ToString("#,#") + " Кредитов.\n" + info_of_biology_additional_info[i] + "\n\n";
            return output_text;
        }

        static public string output_low(int i)
        {
            string output_text = "Название вида: " + Convert.ToString(info_of_biology_name[i]);
            output_text = output_text + "\nСтоимость изучения: " + info_of_biology_cost[i, 0].ToString("#,#") + " Кредитов.\nСтоимость первооктрытия: " + (info_of_biology_cost[i, 1]).ToString("#,#") + " Кредитов.\nОбщая стоимость: "
               + (info_of_biology_cost[i, 0] + info_of_biology_cost[i, 1]).ToString("#,#") + " Кредитов.\n" + info_of_biology_additional_info[i] + "\n\n";
            return output_text;
        }


        static public bool IsMatchedOfSector(int i)
        {
            if (sector == -1)
            {
                return true; 
            }
            bool succes = false;
            if (info_of_biology_sector[i, 0] == 0)
            {
                return true;
            }
            else
            {
                int x1 = 0;
                do
                {
                    if (info_of_biology_sector[i, x1+1]==sector)
                    {
                        succes = true;
                    }
                    x1++;
                } while (x1 < info_of_biology_sector[i, 0] && succes==false);
            }
            if (succes==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool IsMatched(int i)
        {
            return matching[i];
        }

        static public bool IsMatchedOfCost(int i, int down_cost)
        {
            if (down_cost < info_of_biology_cost[i, 0] + info_of_biology_cost[i, 1])
            {
                return true;
            }
            else return false;
        }

        static public void IsMatchedWithFilters (int i, bool f1, bool f2, bool f3, bool f4)
        {
            int x1 = 0;
            int x2 = 0;
            int x3 = 0;
            if (f1 == false)
            {
                if (f2 == false)
                {
                    if (f3 == false)
                    {
                        if (f4 == true)
                        {
                            if (info_of_biology_support[i, 1, 0] > 0 || info_of_biology_support[i, 0, 0] > 0)
                            {
                                do
                                {
                                    if ((info_of_biology_gravity[i, x1, 0] <= gravity && info_of_biology_gravity[i, x1, 1] >= gravity))
                                    {
                                        matching[i] = true;
                                    }
                                    x1++;
                                } while (info_of_biology_support[i, 1, 0] > x1 || info_of_biology_support[i, 0, 0] > x1);
                            }
                            else
                            {
                                if ((info_of_biology_gravity[i, 0, 0] <= gravity && info_of_biology_gravity[i, 0, 1] >= gravity))
                                {
                                    matching[i] = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (f4 == false)
                        {
                            if (info_of_biology_support[i, 1, 0] > 0 || info_of_biology_support[i, 0, 0] > 0)
                            {
                                do
                                {
                                    if ((info_of_biology_temperature[i, x1, 0] <= temperature && info_of_biology_temperature[i, x1, 1] >= temperature))
                                    {
                                        matching[i] = true;
                                    }
                                    x1++;
                                } while (info_of_biology_support[i, 1, 0] > x1 || info_of_biology_support[i, 0, 0] > x1);
                            }
                            else
                            {
                                if ((info_of_biology_temperature[i, 0, 0] <= temperature && info_of_biology_temperature[i, 0, 1] >= temperature))
                                {
                                    matching[i] = true;
                                }
                            }
                        }
                        else
                        {
                            do
                            {
                                if ((info_of_biology_temperature[i, x1, 0] <= temperature && info_of_biology_temperature[i, x1, 1] >= temperature))
                                {
                                    if ((info_of_biology_gravity[i, x1, 0] <= gravity && info_of_biology_gravity[i, x1, 1] >= gravity))
                                    {
                                        matching[i] = true;
                                    }
                                }
                                else if (info_of_biology_support[i, 0, 0] == 0 && info_of_biology_support[i, 1, 0] == 0 && (info_of_biology_temperature[i, 0, 0] <= temperature && info_of_biology_temperature[i, 0, 1] >= temperature) && info_of_biology_gravity[i, 0, 0] <= gravity && info_of_biology_gravity[i, 0, 1] >= gravity)
                                {
                                    matching[i] = true;
                                }
                                x1++;
                            } while (info_of_biology_support[i, 1, 0] > x1 || info_of_biology_support[i, 0, 0] > x1);
                        }
                    }
                }
                else
                {
                    do
                    {
                        if (atmosphere == info_of_biology_atmosphere[i, x2])
                        {
                            if (f3 == false)
                            {
                                if (f4 == false)
                                {
                                    matching[i] = true;
                                }
                                else
                                {
                                    if (info_of_biology_support[i, 1, 0] > 0 || info_of_biology_support[i, 0, 0] > 0)
                                    {
                                        do
                                        {
                                            if ((info_of_biology_gravity[i, x1, 0] <= gravity && info_of_biology_gravity[i, x1, 1] >= gravity) && ((info_of_biology_support[i, 0, 0] > 0) || (info_of_biology_support[i, 1, 0] > 0 && x2 == x1)))
                                            {
                                                matching[i] = true;
                                            }
                                            x1++;
                                        } while (info_of_biology_support[i, 1, 0] > x1 || info_of_biology_support[i, 0, 0] > x1);
                                    }
                                    else
                                    {
                                        if ((info_of_biology_gravity[i, 0, 0] <= gravity && info_of_biology_gravity[i, 0, 1] >= gravity))
                                        {
                                            matching[i] = true;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (f4 == false)
                                {
                                    if (info_of_biology_support[i, 1, 0] > 0 || info_of_biology_support[i, 0, 0] > 0)
                                    {
                                        do
                                        {
                                            if ((info_of_biology_temperature[i, x1, 0] <= temperature && info_of_biology_temperature[i, x1, 1] >= temperature) && ((info_of_biology_support[i, 0, 0] > 0) || (info_of_biology_support[i, 1, 0] > 0 && x2 == x1)))
                                            {
                                                matching[i] = true;
                                            }
                                            x1++;
                                        } while (info_of_biology_support[i, 1, 0] > x1 || info_of_biology_support[i, 0, 0] > x1);
                                    }
                                    else
                                    {
                                        if ((info_of_biology_temperature[i, 0, 0] <= temperature && info_of_biology_temperature[i, 0, 1] >= temperature))
                                        {
                                            matching[i] = true;
                                        }
                                    }
                                }
                                else
                                {
                                    do
                                    {
                                        if ((info_of_biology_temperature[i, x1, 0] <= temperature && info_of_biology_temperature[i, x1, 1] >= temperature) && ((info_of_biology_support[i, 0, 0] > 0) || (info_of_biology_support[i, 1, 0] > 0 && x2 == x1)))
                                        {
                                            if ((info_of_biology_gravity[i, x1, 0] <= gravity && info_of_biology_gravity[i, x1, 1] >= gravity))
                                            {
                                                matching[i] = true;
                                            }
                                        }
                                        else if (info_of_biology_support[i, 0, 0] == 0 && info_of_biology_support[i, 1, 0] == 0 && (info_of_biology_temperature[i, 0, 0] <= temperature && info_of_biology_temperature[i, 0, 1] >= temperature) && info_of_biology_gravity[i, 0, 0] <= gravity && info_of_biology_gravity[i, 0, 1] >= gravity)
                                        {
                                            matching[i] = true;
                                        }
                                        x1++;
                                    } while (info_of_biology_support[i, 1, 0] > x1 || info_of_biology_support[i, 0, 0] > x1);
                                }
                            }
                        }
                        x2++;
                    } while (x2 < info_of_biology_support[i, 1, 1]);
                }
            }
            else
            {
                do
                {
                    if (type_of_planet == info_of_biology_type_of_planet[i, x3])
                    {
                        if (f2 == false)
                        {
                            if (f3 == false)
                            {
                                if (f4 == true)
                                {
                                    if (info_of_biology_support[i, 1, 0] > 0 || info_of_biology_support[i, 0, 0] > 0)
                                    {
                                        do
                                        {
                                            if ((info_of_biology_gravity[i, x1, 0] <= gravity && info_of_biology_gravity[i, x1, 1] >= gravity) && ((info_of_biology_support[i, 1, 0] > 0) || (info_of_biology_support[i, 0, 0] > 0 && x3 == x1)))
                                            {
                                                matching[i] = true;
                                            }
                                            x1++;
                                        } while (info_of_biology_support[i, 1, 0] > x1 || info_of_biology_support[i, 0, 0] > x1);
                                    }
                                    else
                                    {
                                        if ((info_of_biology_gravity[i, 0, 0] <= gravity && info_of_biology_gravity[i, 0, 1] >= gravity))
                                        {
                                            matching[i] = true;
                                        }
                                    }
                                }
                                else
                                {
                                    matching[i] = true;
                                }
                            }
                            else
                            {
                                if (f4 == false)
                                {
                                    if (info_of_biology_support[i, 1, 0] > 0 || info_of_biology_support[i, 0, 0] > 0)
                                    {
                                        do
                                        {
                                            if ((info_of_biology_temperature[i, x1, 0] <= temperature && info_of_biology_temperature[i, x1, 1] >= temperature) && ((info_of_biology_support[i, 1, 0] > 0) || (info_of_biology_support[i, 0, 0] > 0 && x3 == x1)))
                                            {
                                                matching[i] = true;
                                            }
                                            x1++;
                                        } while (info_of_biology_support[i, 1, 0] > x1 || info_of_biology_support[i, 0, 0] > x1);
                                    }
                                    else
                                    {
                                        if ((info_of_biology_temperature[i, 0, 0] <= temperature && info_of_biology_temperature[i, 0, 1] >= temperature))
                                        {
                                            matching[i] = true;
                                        }
                                    }
                                }
                                else
                                {
                                    do
                                    {
                                        if ((info_of_biology_temperature[i, x1, 0] <= temperature && info_of_biology_temperature[i, x1, 1] >= temperature) && ((info_of_biology_support[i, 1, 0] > 0) || (info_of_biology_support[i, 0, 0] > 0 && x3 == x1)))
                                        {
                                            if ((info_of_biology_gravity[i, x1, 0] <= gravity && info_of_biology_gravity[i, x1, 1] >= gravity))
                                            {
                                                matching[i] = true;
                                            }
                                        }
                                        else if (info_of_biology_support[i, 0, 0] == 0 && info_of_biology_support[i, 1, 0] == 0 && (info_of_biology_temperature[i, 0, 0] <= temperature && info_of_biology_temperature[i, 0, 1] >= temperature) && info_of_biology_gravity[i, 0, 0] <= gravity && info_of_biology_gravity[i, 0, 1] >= gravity)
                                        {
                                            matching[i] = true;
                                        }
                                        x1++;
                                    } while (info_of_biology_support[i, 1, 0] > x1 || info_of_biology_support[i, 0, 0] > x1);
                                }
                            }
                        }
                        else
                        {
                            do
                            {
                                if (atmosphere == info_of_biology_atmosphere[i, x2])
                                {
                                    if (f3 == false)
                                    {
                                        if (f4 == false)
                                        {
                                            matching[i] = true;
                                        }
                                        else
                                        {
                                            if (info_of_biology_support[i, 1, 0] > 0 || info_of_biology_support[i, 0, 0] > 0)
                                            {
                                                do
                                                {
                                                    if ((info_of_biology_gravity[i, x1, 0] <= gravity && info_of_biology_gravity[i, x1, 1] >= gravity) && ((info_of_biology_support[i, 1, 0] > 0 && x2 == x1) || (info_of_biology_support[i, 0, 0] > 0 && x3 == x1)))
                                                    {
                                                        matching[i] = true;
                                                    }
                                                    x1++;
                                                } while (info_of_biology_support[i, 1, 0] > x1 || info_of_biology_support[i, 0, 0] > x1);
                                            }
                                            else
                                            {
                                                if ((info_of_biology_gravity[i, 0, 0] <= gravity && info_of_biology_gravity[i, 0, 1] >= gravity))
                                                {
                                                    matching[i] = true;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (f4 == false)
                                        {
                                            if (info_of_biology_support[i, 1, 0] > 0 || info_of_biology_support[i, 0, 0] > 0)
                                            {
                                                do
                                                {
                                                    if ((info_of_biology_temperature[i, x1, 0] <= temperature && info_of_biology_temperature[i, x1, 1] >= temperature) && ((info_of_biology_support[i, 1, 0] > 0 && x2 == x1) || (info_of_biology_support[i, 0, 0] > 0 && x3 == x1)))
                                                    {
                                                        matching[i] = true;
                                                    }
                                                    x1++;
                                                } while (info_of_biology_support[i, 1, 0] > x1 || info_of_biology_support[i, 0, 0] > x1);
                                            }
                                            else
                                            {
                                                if ((info_of_biology_temperature[i, 0, 0] <= temperature && info_of_biology_temperature[i, 0, 1] >= temperature))
                                                {
                                                    matching[i] = true;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            do
                                            {
                                                if ((info_of_biology_temperature[i, x1, 0] <= temperature && info_of_biology_temperature[i, x1, 1] >= temperature) && ((info_of_biology_support[i, 1, 0] > 0 && x2 == x1) || (info_of_biology_support[i, 0, 0] > 0 && x3 == x1)))
                                                {
                                                    if ((info_of_biology_gravity[i, x1, 0] <= gravity && info_of_biology_gravity[i, x1, 1] >= gravity))
                                                    {
                                                        matching[i] = true;
                                                    }
                                                }
                                                else if (info_of_biology_support[i, 0, 0] == 0 && info_of_biology_support[i, 1, 0] == 0 && (info_of_biology_temperature[i, 0, 0] <= temperature && info_of_biology_temperature[i, 0, 1] >= temperature) && info_of_biology_gravity[i, 0, 0] <= gravity && info_of_biology_gravity[i, 0, 1] >= gravity)
                                                {
                                                    matching[i] = true;
                                                }
                                                x1++;
                                            } while (info_of_biology_support[i, 1, 0] > x1 || info_of_biology_support[i, 0, 0] > x1);
                                        }
                                    }
                                }
                                x2++;
                            } while (x2 < info_of_biology_support[i, 1, 1]);
                        }
                    }
                    x3++;
                } while (x3 < info_of_biology_support[i, 0, 1]);
            }
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}