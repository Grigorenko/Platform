﻿using Microsoft.AspNetCore.Mvc;
using Core.Data;

namespace Core.Infrastructure.Mvc.Controllers
{
  public abstract class ControllerBase : Controller
  {
    public IStorage Storage { get; private set; }

    public ControllerBase(IStorage storage)
    {
      this.Storage = storage;
    }
  }
}
