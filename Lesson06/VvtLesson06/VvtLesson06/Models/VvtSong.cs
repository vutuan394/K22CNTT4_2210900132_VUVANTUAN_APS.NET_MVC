using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VvtLesson06.Models
{
    public class VvtSong
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Vvt: Hãy Nhập Tiêu Đề")]
        [DisplayName("Tiêu Đề")]
        public string VvtTitle { get; set; }
        [Required (ErrorMessage ="Vvt: hãy Nhập Tác Giả")]
        [DisplayName("Tác Giả ")]
        public string VvtAuthor { get; set; }
        [Required (ErrorMessage ="vvt: Hãy Nhập Nghệ Sĩ")]
        [DisplayName("Nghệ Sĩ ")]
        [StringLength (50,MinimumLength =2,ErrorMessage ="Vvt: Tên Nghệ Sĩ Có Tối Thiểu 2 Kí Tự, Tối Đa 509 Ký Tự ")]
        public string VvtArtist { get; set; }
        [Required (ErrorMessage ="Vvt: Hãy Nhập năm Xuất bản ")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage ="Vvt: Nhập Xuất Bản Phải có 2 kí tự số ")]
        [Range(1900,2024,ErrorMessage ="Vvt: Năm Xuất Bản Trong khoảng 1900 - 2024 ")]
        [DisplayName("Năm Xuất Bản")]
        public int VvtYearRelease { get; set; }







    }
}