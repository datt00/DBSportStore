// Dùng ProductCardViewModel trong thư mục Models
using DBSportStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Namespace chứa các Controller
namespace DBSportStore.Controllers
{
    // Controller xử lý các request của trang Store
    public class StoreController : Controller
    {
        // GET: Store
        // Action Index xử lý URL /Store/Index
        public ActionResult Index()
        {
            // Tạo danh sách sản phẩm mẫu
            var products = new List<ProductCardViewModel>
            {
                // Sản phẩm mẫu 1 
                new ProductCardViewModel 
                { 
                    ProductID = 1, 
                    NamePro = "Nike Air Zoom", 
                    CategoryName = "Giày thể thao", 
                    Price = 1290000, 
                    ImagePro = "shoe-01.jpg",
                    ShortDescription = "Giày chạy bộ Nike Air Zoom với thiết kế nhẹ và thoáng khí, giúp bạn đạt hiệu suất tối đa trong mỗi bước chạy."
                },
                // Sản phẩm mẫu 2
                new ProductCardViewModel 
                { 
                    ProductID = 2, 
                    NamePro = "Adidas Training Tee", 
                    CategoryName = "Áo quần thi đấu", 
                    Price = 590000, 
                    ImagePro = "shirt-01.jpg", 
                    ShortDescription = "Áo tập thể thao Adidas với chất liệu thấm hút mồ hôi, giúp bạn luôn cảm thấy thoải mái trong quá trình tập luyện."
                },
                // Sản phẩm mẫu 3
                new ProductCardViewModel 
                { 
                    ProductID = 3, 
                    NamePro = "Gym Performance Set", 
                    CategoryName = "Dụng cụ thể thao", 
                    Price = 890000, 
                    ImagePro = "gym-01.jpg",
                    ShortDescription = "Bộ dụng cụ tập luyện chuyên dụng với nhiều chức năng, giúp bạn tối ưu hóa hiệu suất tập luyện."
                },
                // Sản phẩm mẫu 4 
                new ProductCardViewModel 
                { 
                    ProductID = 4, 
                    NamePro = "Running Shoes Pro", 
                    CategoryName = "Giày thể thao", 
                    Price = 1490000, 
                    ImagePro = "shoe-02.jpg",
                    ShortDescription = "Giày chạy bộ Running Shoes Pro với công nghệ hấp thụ sốc tiên tiến, mang lại trải nghiệm thoải mái khi vận động."
                },
                //Sản phẩm mẫu 5
                new ProductCardViewModel
                {
                    ProductID = 5,
                    NamePro = "Quần áo đá banh đội tuyển Việt Nam",
                    CategoryName = "Áo quần thi đấu",
                    Price = 150000,
                    ImagePro = "quan ao da banh.jpg",
                    ShortDescription = "Quần áo đá banh của đội tuyển Việt Nam với thiết kế năng động và chất liệu cao cấp."    
                },
                //Sản phẩm mẫu 6 
                new ProductCardViewModel
                {
                    ProductID = 6,
                    NamePro = "Vợt Pickleball Soxter",
                    CategoryName = "Dụng cụ thể thao",
                    Price = 4258800,
                    ImagePro = "vot pickleball.jpg", 
                    ShortDescription ="Vợt Pickleball Soxter với thiết kế hiện đại, giúp bạn nâng cao kỹ năng chơi pickleball và trải nghiệm thể thao tuyệt vời."
                },
                //Sản phẩm mẫu 7
                new ProductCardViewModel
                {
                    ProductID = 7,
                    NamePro = "Găng tay thủ môn",
                    CategoryName = "Phụ kiện thể thao",
                    Price = 1300000,
                    ImagePro = "gang tay thu mon.jpg",
                    ShortDescription= "Găng tay thủ môn chất lượng cao, giúp bảo vệ tay và tăng khả năng bắt bóng trong các trận đấu."
                }
            };

            // Truyền products sang View Index
            return View(products);


        }
        public ActionResult AboutStore()
        {
            return View();
        }

    }
}
