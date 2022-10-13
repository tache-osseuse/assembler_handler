﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class CodeChecker
    {
        private int address_counter;
        private List<string[]> code;
        private List<string[]> name_table;
        private List<string[]> add_table;
        private List<string[]> code_table;
        private string[] registers = { "R1", "R2", "R3", "R4" };
        private int last_address;

        public CodeChecker(List<string[]> code_t)
        {
            this.code = new List<string[]>();
            this.name_table = new List<string[]>();
            this.add_table = new List<string[]>();
            this.code_table = code_t;
        }

        public List<string[]> get_nt()
        {
            return this.name_table;
        }

        public List<string[]> get_at()
        {
            return this.add_table;
        }

        private void set_code(string[] b_code)
        {
            foreach (var str in b_code) // проверка на пустые строки
            {
                // проверка на пустые строки в самих передаваемых строках
                this.code.Add(str.Split());
            }
        }

        private string calculate_cc()
        {
            return " ";
        }

        private void show_ex(string[] line)
        {
            int ct = 1;
            Console.WriteLine("[" + ct.ToString() + "]");
            foreach (string smb in line)
            {
                Console.WriteLine("=> " + smb);
            }
        }

        public void show_code()
        {
            foreach (var st in this.code)
            {
                foreach (var el in st)
                {
                    Console.WriteLine(el);
                }
            }
        }

        public string[] get_command_code(string[] command)
        {
            string[] def = { };
            
            foreach (string[] st in this.code_table)
            {
                if (st[0] == (command[1] + " "))
                {
                    string[] res = { st[1], st[2] };
                    return res;
                }
                else if (st[0] == (command[1] + " " + command[2] + " ")){
                    string[] res = { st[1], st[2] };
                    return res;
                }
            }
            return def;
        }

        public bool check_begin_address()
        {
            if (this.code[0].Length == 3) // проверка на имя программы
            {
                if (int.TryParse(this.code[0][2], out _))
                {
                    return true;
                }
            }
            return false;
        }

        public void first_cycle(string[] st)
        {
            bool check_begin = false;
            bool command_show = false;
            int cd;
            this.set_code(st);
            if (check_begin_address()) // + проверка на переполнение
            {
                this.address_counter = Int32.Parse(code[0][2]);
                Console.WriteLine(this.address_counter);
            }
            else {
                Console.WriteLine("Неправильный начальный адрес!");
                return;
            }

            foreach (string[] str in this.code) // на каждой итерации проверять адреса на переполнение
            {
                if (!check_begin) // проверка первой строки
                {
                    check_begin = true;
                    string[] at1 = { str[0], str[1], str[2], " " };
                    add_table.Add(at1);
                    continue;
                }
                if (str[0] != "_") // проверка метки, еще добавить проверку на присутствие такого в таблице
                {
                    string[] tp = { str[0], " " };
                    name_table.Add(tp);
                }
            }
            check_begin = false;

            foreach (string[] str in this.code)
            {
                if (!check_begin)
                {
                    check_begin = true;
                    continue;
                }
                string[] check_ca = get_command_code(str);
                if (check_ca.Length != 0) // добавить нормальную проверку на директиву
                {
                    command_show = true;
                }
                if (str[0] != "_") // проверка метки, еще добавить проверку на присутствие такого в таблице
                {
                    string[] at2;
                    if (str.Length == 4)
                    {
                        if (command_show == true)
                        {
                            if (registers.Contains(str[2]) && registers.Contains(str[3]))
                            {
                                cd = Int32.Parse(check_ca[0]) * 4;
                            }
                            else // проверка на R1..
                            {
                                cd = Int32.Parse(check_ca[0]) * 4 + 1;
                            }
                            at2 = new string[] { "Адрес", cd.ToString(), str[2], str[3] };
                            add_table.Add(at2);
                        }
                        else
                        {
                            at2 = new string[] { "Адрес", str[1], str[2], str[3] };
                            add_table.Add(at2);
                        }
                    }
                    else if (str.Length == 3)
                    {
                        if (command_show == true)
                        {
                            show_ex(check_ca);
                        }
                        else
                        {
                            at2 = new string[] { "Адрес", str[1], str[2], " " };
                            add_table.Add(at2);
                        }
                    }
                }
                else
                {
                    string[] at3;
                    if (str.Length == 3)
                    {
                        if (command_show == true)
                        {
                            at3 = new string[] { "Адрес", (Int32.Parse(check_ca[0]) * 4 + 1).ToString(), str[2], " " };
                            add_table.Add(at3);
                        }
                        else
                        {
                            at3 = new string[] { "Адрес", str[1], str[2], " " };
                            add_table.Add(at3);
                        }
                    }
                    else if (str.Length == 4)
                    {
                        if (command_show == true)
                        {
                            if (registers.Contains(str[2]) && registers.Contains(str[3]))
                            {
                                cd = Int32.Parse(check_ca[0]) * 4;
                            }
                            else // проверка на R1..
                            {
                                cd = Int32.Parse(check_ca[0]) * 4 + 1;
                            }
                            at3 = new string[] { "Адрес", cd.ToString(), str[2], str[3] };
                            add_table.Add(at3);
                        }
                        else
                        {
                            at3 = new string[] { "Адрес", str[1], str[2], str[3] };
                            add_table.Add(at3);
                        }
                    }
                }
                command_show = false;
            }
        }
    }
}
