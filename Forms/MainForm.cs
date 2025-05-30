using SmartInventoryApp.Services;

namespace SmartInventoryApp.Forms
{
    public partial class MainForm : Form
    {
        ProductService _productService;
        public MainForm(ProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        protected override void OnLoad(EventArgs e)
        {
            var products = _productService.GetAll();
            dgvProducts.DataSource = products;
            base.OnLoad(e);
        }
    }
}
