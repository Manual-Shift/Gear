﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/// <summary>
/// Domantas Banionis
/// </summary>
namespace Gear.Controllers
{
    public class StoreController : Controller
    {
        List<Gear.ViewModels.GameViewModel> TemporarySet = new List<Gear.ViewModels.GameViewModel>
                {
                    new Gear.ViewModels.GameViewModel
                    {
                        Game = new Gear.Models.Game { Name = "The Witcher® 3: Wild Hunt" },
                        Picture = new Gear.Models.Picture { Directory = "../Content/images/witcher.jpg" }
                    },
                    new Gear.ViewModels.GameViewModel
                    {
                        Game = new Gear.Models.Game { Name = "The Witcher® 3: Wild Hunt" },
                        Picture = new Gear.Models.Picture { Directory = "../Content/images/witcher.jpg" }
                    },
                    new Gear.ViewModels.GameViewModel
                    {
                        Game = new Gear.Models.Game { Name = "The Witcher® 3: Wild Hunt" },
                        Picture = new Gear.Models.Picture { Directory = "../Content/images/witcher.jpg" }
                    },
                    new Gear.ViewModels.GameViewModel
                    {
                        Game = new Gear.Models.Game { Name = "The Witcher® 3: Wild Hunt" },
                        Picture = new Gear.Models.Picture { Directory = "../Content/images/witcher.jpg" }
                    },
                    new Gear.ViewModels.GameViewModel
                    {
                        Game = new Gear.Models.Game { Name = "The Witcher® 3: Wild Hunt" },
                        Picture = new Gear.Models.Picture { Directory = "../Content/images/witcher.jpg" }
                    },
                    new Gear.ViewModels.GameViewModel
                    {
                        Game = new Gear.Models.Game { Name = "The Witcher® 3: Wild Hunt" },
                        Picture = new Gear.Models.Picture { Directory = "../Content/images/witcher.jpg" }
                    },
                    new Gear.ViewModels.GameViewModel
                    {
                        Game = new Gear.Models.Game { Name = "The Witcher® 3: Wild Hunt" },
                        Picture = new Gear.Models.Picture { Directory = "../Content/images/witcher.jpg" }
                    },
                };

        // GET: Store
        public ActionResult Index(int? listcategory)
        {
            if (!listcategory.HasValue)
            {
                listcategory = 1;
            }

            var tmp = new Gear.ViewModels.StoreViewModel()
            {
                Showcase = TemporarySet,
                Newest = TemporarySet,
                Pupular = TemporarySet,
                Discounted = TemporarySet,
                Category = (int)listcategory
            };

            

            return View(tmp);
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Payment()
        {
            return View();
        }
    }
}