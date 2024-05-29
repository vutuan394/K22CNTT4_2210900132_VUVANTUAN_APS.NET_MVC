using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VvtLesson06.Models;

namespace VvtLesson06.Controllers
{
    public class VvtSongController : Controller
    {
        private static List<VvtSong> vvtSongs = new List<VvtSong>()
        {
            new VvtSong{Id=132, VvtTitle= "Vu Van Tuan", VvtAuthor= "K22CNTT4",VvtArtist= "NTU", VvtYearRelease= 2024},
            new VvtSong{Id=02, VvtTitle= "Vu Van Tuan02", VvtAuthor= "K22CNTT402",VvtArtist= "NTU02", VvtYearRelease= 202402}

        }
        // GET: VvtSong
        /// <summary>
        /// Hiển thị danh sách bài hát
        /// Author: Vũ Văn Tuấn 
        /// </summary>
        /// <returns></returns>
        public ActionResult VvtIndex()
        {
            return View(vvtSongs);
        }
        //Get: VvtCreate
        /// <summary>
        /// From Thêm Mới Bài hát 
        /// Author: Vũ Văn Tuấn 
        /// </summary>
        /// <returns></returns>
        public ActionResult VvtCreate() 
        {
            var vvtSong = new VvtSong();
            return View(vvtSong);
        }
    }
}