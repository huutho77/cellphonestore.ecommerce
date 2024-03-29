using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace CellphoneStoreEcommerce.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "Mã sản phẩm")]
        public int product_ID { get; set; }

        [Required(ErrorMessage = "Nhập thông tin cho trường này!!!")]
        [Display(Name = "Tên sản phẩm")]
        public string product_Name { get; set; }

        [Required(ErrorMessage = "Nhập thông tin cho trường này!!!")]
        [Display(Name = "Giá sản phẩm")]
        [DataType(DataType.Currency)]
        // [DisplayFormat(DataFormatString = "{0:C2}")]     /* Cách thứ 2 để định dạng tiền tệ */
        [Range(10000, 100000000, ErrorMessage = "Giá thấp nhất là 10,000vnđ và tối đa là 100,000,000vnđ")]
        public decimal product_Price { get; set; }

        [Required(ErrorMessage = "Nhập thông tin cho trường này!!!")]
        [Display(Name = "Số lượng sản phẩm")]
        [Range(1, 1000, ErrorMessage = "Số lượng tối thiểu là 1 và tối đa là 1,000")]
        public int product_Quantity { get; set; }

        [Display(Name = "Hệ điều hành sản phẩm")]
        public string product_OS { get; set; }

        [Display(Name = "Mô tả sản phẩm")]
        public string product_Description { get; set; }

        [Display(Name = "Hình ảnh")]
        public string product_Image { get; set; }


        // Foreign Key
        [ForeignKey("ProductCategories")]
        public int proCategory_ID { get; set; }

        [ForeignKey("NhaCungCap")]
        public int nhacungcap_ID { get; set; }


        // Get to list
        public IEnumerable<Comment> lsComment { get; set; }


        // constructror
        public Product() { }
        public Product(int product_ID,
                       string product_Name,
                       decimal product_Price,
                       int product_Quantity,
                       string product_OS,
                       string product_Description,
                       int nhacungcap_ID,
                       int proCategory_ID,
                       string product_Image)
        {
            this.product_ID = product_ID;
            this.product_Name = product_Name;
            this.product_Price = product_Price;
            this.product_Quantity = product_Quantity;
            this.product_OS = product_OS;
            this.product_Description = product_Description;
            this.nhacungcap_ID = nhacungcap_ID;
            this.proCategory_ID = proCategory_ID;
            this.product_Image = product_Image;
        }

    }
}
