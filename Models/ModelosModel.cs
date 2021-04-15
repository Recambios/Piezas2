﻿using Microsoft.AspNetCore.Http;
using Piezas2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Html;
using static Piezas2.Core.Coches;

namespace Piezas2.Models
  {
  //=======================================================================================================================================
  /// <summary> Obtiene todos los datos necesarios para el cuadro de busqueda de recambios </summary>
  public class ModelosModel : BaseModel
    {
    public List<CocheDescFull> Coches { set; get; }
    public string Marca { set; get; }

    //---------------------------------------------------------------------------------------------------------------------------------------
    /// <summary> Construye el objeto y obtiene los datos de la base de datos </summary>
    public ModelosModel( string marca, HttpContext HttpCtx ) : base( HttpCtx )
      {
      Marca = marca.ToUpper();

      Coches = new Coches( HttpCtx ).FullDesc( Marca );
      }
    }
  }
  