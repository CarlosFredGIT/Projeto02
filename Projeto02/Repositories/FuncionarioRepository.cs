﻿using Newtonsoft.Json;
using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Projeto02.Repositories
{
    public class FuncionarioRepository
    {
        public void ExportarJSON(Funcionario funcionario)
        {
            var path = $"c:\\temp\\funcionario_{funcionario.IdFuncionario}.json";

            var streamWriter = new StreamWriter(path);

            var json = JsonConvert.SerializeObject(funcionario);

            streamWriter.WriteLine(json);

            streamWriter.Close();
        }
    }
}
