﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Piezas2.Models;

namespace Piezas2.Controllers
  {
  //=======================================================================================================================================
  // Controlador que sirve como punto de entrada a todas las páginas del sitio
  public class SiteController : Controller
    {
    private readonly ILogger<SiteController> _logger;

    //---------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> Crea el objeto antes de ejecutar cualquier acción </summary>
    public SiteController( ILogger<SiteController> logger )
      {
      _logger = logger;
      }

    //---------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> Página principal del sitio </summary>
    [Route( "/recambios" )]
    [HttpGet( "/" )]
    public IActionResult Index()
      {
      var model = new FindRecambioModel( HttpContext );
      return View( model );
      }

    //---------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> Página principal del sitio </summary>
    [Route( "/recambio/{id:int}/{name?}" )]
    public IActionResult Recambio( int id )
      {
      var model = new RecambioModel( id, HttpContext );
      return View( model );
      }

    //---------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> Página que muestra los errores que se produzcan en el sitio </summary>
    [HttpGet( "/error/{code?}" )]
    [ResponseCache( Duration = 0, Location = ResponseCacheLocation.None, NoStore = true )]
    public IActionResult Error( string code )
      {
      var model = new ErrorViewModel( code, HttpContext );

      return View( model );
      }
    }

  }
