﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CShp_MAC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 
        /// DATABASE MODEL =>
        ///     carro -> pk(placa), modelo, pk(cpf), numero
        ///     infrações -> pk(data/hora), pk(FK(placa)), Infrações
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FMainWindow());
            
        }
    }
}
