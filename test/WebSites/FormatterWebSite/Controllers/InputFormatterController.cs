// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;

namespace FormatterWebSite.Controllers
{
    public class InputFormatterController : Controller
    {
        public IActionResult ReturnInput([FromBody] string test)
        {
            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(StatusCodes.Status400BadRequest);
            }

            return Content(test);
        }
    }
}