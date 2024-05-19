using Utils;
using Products;
using Interfaces;

namespace KP
{
    public enum OperationType
    {
        Add,
        Edit,
        AddToCart
    }

    public partial class ProductForm : Form
    {
        private Product product;
        private ProductUtils productUtils;
        private OperationType operationType;
        Label cpuCoresCount = new Label();
        TextBox cpuCoresCountBox = new TextBox();
        Label cpuFrequency = new Label();
        TextBox cpuFrequencyBox = new TextBox();
        Label cpuSocket = new Label();
        TextBox cpuSocketBox = new TextBox();

        Label motherboardSocket = new Label();
        TextBox motherboardSocketBox = new TextBox();
        Label motherboardChipset = new Label();
        TextBox motherBoardChipsetBox = new TextBox();
        Label motherboardRam = new Label();
        TextBox motherboardRamBox = new TextBox();

        Label ramCapacity = new Label();
        TextBox ramCapacityBox = new TextBox();
        Label ramFrequency = new Label();
        TextBox ramFrequencyBox = new TextBox();
        Label ramCount = new Label();
        TextBox ramCountBox = new TextBox();
        Label ramType = new Label();
        ComboBox ramTypeBox = new ComboBox();

        Label gpuPower = new Label();
        TextBox gpuPowerBox = new TextBox();
        Label gpuMemoryCapacity = new Label();
        TextBox gpuMemoryCapacityBox = new TextBox();
        Label gpuMemoryType = new Label();
        ComboBox gpuMemoryTypeBox = new ComboBox();
        Label gpuInterface = new Label();
        ComboBox gpuInterfaceBox = new ComboBox();

        Label driveCapacity = new Label();
        TextBox driveCapacityBox = new TextBox();
        Label driveType = new Label();
        ComboBox driveTypeBox = new ComboBox();
        Label driveInterface = new Label();
        ComboBox driveInterfaceBox = new ComboBox();
        Label driveRead = new Label();
        TextBox driveReadBox = new TextBox();
        Label driveWrite = new Label();
        TextBox driveWriteBox = new TextBox();

        Label supplyPower = new Label();
        TextBox supplyPowerBox = new TextBox();

        public ProductForm(OperationType operationType, Product product = null)
        {
            InitializeComponent();
            this.operationType = operationType;
            this.product = product;

            cpuCoresCountBox.KeyPress += countBox_KeyPress;
            cpuFrequencyBox.KeyPress += productPriceBox_KeyPress;
            cpuFrequencyBox.TextChanged += priceBox_TextChanged;
            motherboardRamBox.KeyPress += countBox_KeyPress;
            ramCapacityBox.KeyPress += countBox_KeyPress;
            ramFrequencyBox.KeyPress += productPriceBox_KeyPress;
            ramFrequencyBox.TextChanged += priceBox_TextChanged;
            ramCountBox.KeyPress += countBox_KeyPress;
            gpuPowerBox.KeyPress += countBox_KeyPress;
            gpuMemoryCapacityBox.KeyPress += countBox_KeyPress;
            driveCapacityBox.KeyPress += countBox_KeyPress;
            driveReadBox.KeyPress += countBox_KeyPress;
            driveWriteBox.KeyPress += countBox_KeyPress;
            supplyPowerBox.KeyPress += countBox_KeyPress;

            if (product != null)
            {
                captionBox.Text = product.ProductCaption;
                categoryBox.Text = ProductUtils.GetCategory(product);
                priceBox.Text = product.ProductPrice.ToString();
                countBox.Text = product.ProductCount.ToString();
                descriptionBox.Text = product.ProductDescription;
                manufacturerBox.Text = product.ProductManufacturer;

            }
            switch (operationType)
            {
                case OperationType.Add: performtButton.Text = "Додати"; break;
                case OperationType.Edit: performtButton.Text = "Редагувати"; break;
                case OperationType.AddToCart:
                    {
                        performtButton.Text = "Придбати";
                        textBoxCount.Visible = true;
                        label1.Visible = true;
                        performtButton.Enabled = product.ProductCount > 0;
                        break;
                    }
            }
            if (operationType == OperationType.AddToCart)
            {
                captionBox.ReadOnly = true;
                captionBox.BorderStyle = BorderStyle.None;
                categoryBox.Enabled = false;
                priceBox.ReadOnly = true;
                priceBox.BorderStyle = BorderStyle.None;
                countBox.ReadOnly = true;
                countBox.BorderStyle = BorderStyle.None;
                descriptionBox.ReadOnly = true;
                manufacturerBox.ReadOnly = true;
                cpuCoresCountBox.ReadOnly = true;
                cpuFrequencyBox.ReadOnly = true;
                cpuSocketBox.ReadOnly = true;
                motherboardSocketBox.ReadOnly = true;
                motherBoardChipsetBox.ReadOnly = true;
                motherboardRamBox.ReadOnly = true;
                ramCapacityBox.ReadOnly = true;
                ramFrequencyBox.ReadOnly = true;
                ramCountBox.ReadOnly = true;
                ramTypeBox.Enabled = false;
                gpuPowerBox.ReadOnly = true;
                gpuMemoryCapacityBox.ReadOnly = true;
                gpuMemoryTypeBox.Enabled = false;
                gpuInterfaceBox.Enabled = false;
                driveCapacityBox.ReadOnly = true;
                driveTypeBox.Enabled = false;
                driveInterfaceBox.Enabled = false;
                driveReadBox.ReadOnly = true;
                driveWriteBox.ReadOnly = true;
                supplyPowerBox.ReadOnly = true;
            }
        }

        private void performtButton_Click(object sender, EventArgs e)
        {
            switch (operationType)
            {
                case OperationType.Add: addProduct(); break;
                case OperationType.Edit: performtButton.Text = "Редагувати"; editProduct(); break;
                case OperationType.AddToCart: performtButton.Text = "Придбати"; addToCart(); break;
            }
        }

        private bool checkParams()
        {
            if (captionBox.Text == "")
            {
                MessageBox.Show("Вкажіть назву!");
                return false;
            }
            if (categoryBox.Text == "")
            {
                MessageBox.Show("Вкажіть категорію!");
                return false;
            }
            if (countBox.Text == "")
            {
                MessageBox.Show("Вкажіть кількість на складі!");
                return false;
            }
            if (descriptionBox.Text == "")
            {
                MessageBox.Show("Заповніть опис!");
                return false;
            }
            if (manufacturerBox.Text == "")
            {
                MessageBox.Show("Вкажіть виробника!");
                return false;
            }
            if (priceBox.Text == "")
            {
                MessageBox.Show("Вкажіть ціну!");
                return false;
            }
            if (descriptionBox.Text == "")
            {
                MessageBox.Show("Вкажіть опис!");
                return false;
            }
            return true;
        }

        private void addProduct()
        {
            if (!checkParams()) return;

            productUtils = new ProductUtils();
            Product productToAdd = null;
            switch (categoryBox.Text)
            {
                case "CPU":
                    {
                        if (cpuCoresCountBox.Text == "" || cpuFrequencyBox.Text == "" || cpuSocketBox.Text == "")
                        {
                            MessageBox.Show("Вкажіть характеристики!", "Помилка", MessageBoxButtons.OK);
                            return;
                        }
                        productToAdd = new CPU(
                            captionBox.Text,
                            manufacturerBox.Text,
                            Convert.ToDouble(priceBox.Text),
                            descriptionBox.Text,
                            Convert.ToUInt32(countBox.Text),
                            Convert.ToUInt32(cpuCoresCountBox.Text),
                            Convert.ToDouble(cpuFrequencyBox.Text),
                            cpuSocketBox.Text
                            );
                        break;
                    }
                case "Motherboard":
                    {
                        if (motherboardSocketBox.Text == "" || motherBoardChipsetBox.Text == "" || motherboardRamBox.Text == "")
                        {
                            MessageBox.Show("Вкажіть характеристики!", "Помилка", MessageBoxButtons.OK);
                            return;
                        }
                        productToAdd = new Motherboard(
                            captionBox.Text,
                            manufacturerBox.Text,
                            Convert.ToDouble(priceBox.Text),
                            descriptionBox.Text,
                            Convert.ToUInt32(countBox.Text),
                            motherboardSocketBox.Text,
                            motherBoardChipsetBox.Text,
                            Convert.ToUInt32(motherboardRamBox.Text)
                            );
                        break;
                    }
                case "RAM":
                    {
                        if (ramCapacityBox.Text == "" || ramFrequencyBox.Text == "" || ramTypeBox.Text == "" || ramCountBox.Text == "")
                        {
                            MessageBox.Show("Вкажіть характеристики!", "Помилка", MessageBoxButtons.OK);
                            return;
                        }
                        productToAdd = new RAM(captionBox.Text,
                            manufacturerBox.Text,
                            Convert.ToDouble(priceBox.Text),
                            descriptionBox.Text,
                            Convert.ToUInt32(countBox.Text),
                            Convert.ToUInt32(ramCapacityBox.Text),
                            Convert.ToUInt32(ramFrequencyBox.Text),
                            (RAMType)ramTypeBox.SelectedItem,
                            Convert.ToUInt32(ramCountBox.Text)
                            );
                        break;
                    }
                case "GPU":
                    {
                        if (gpuPowerBox.Text == "" || gpuMemoryTypeBox.Text == "" || gpuMemoryCapacityBox.Text == "" || gpuInterfaceBox.Text == "")
                        {
                            MessageBox.Show("Вкажіть характеристики!", "Помилка", MessageBoxButtons.OK);
                            return;
                        }
                        productToAdd = new GPU(
                            captionBox.Text,
                            manufacturerBox.Text,
                            Convert.ToDouble(priceBox.Text),
                            descriptionBox.Text,
                            Convert.ToUInt32(countBox.Text),
                            Convert.ToUInt32(gpuPowerBox.Text),
                            (GPUMemoryType)gpuMemoryTypeBox.SelectedItem,
                            Convert.ToUInt32(gpuMemoryCapacityBox.Text),
                            (GPUInterface)gpuInterfaceBox.SelectedItem
                            );
                        break;
                    }
                case "Drive":
                    {
                        if (driveCapacityBox.Text == "" || driveTypeBox.Text == "" || driveInterfaceBox.Text == "" || driveWriteBox.Text == "" || driveReadBox.Text == "")
                        {
                            MessageBox.Show("Вкажіть характеристики!", "Помилка", MessageBoxButtons.OK);
                            return;
                        }
                        productToAdd = new Drive(
                            captionBox.Text,
                            manufacturerBox.Text,
                            Convert.ToDouble(priceBox.Text),
                            descriptionBox.Text,
                            Convert.ToUInt32(countBox.Text),
                            Convert.ToUInt32(driveCapacityBox.Text),
                            (DRIVEType)driveTypeBox.SelectedItem,
                            (DriveInterface)driveInterfaceBox.SelectedItem,
                            Convert.ToUInt32(driveWriteBox.Text),
                            Convert.ToUInt32(driveReadBox.Text)
                            );
                        break;
                    }
                case "Power Supply":
                    {
                        if (supplyPowerBox.Text == "")
                        {
                            MessageBox.Show("Вкажіть характеристики!", "Помилка", MessageBoxButtons.OK);
                            return;
                        }
                        productToAdd = new PowerSupply(
                            captionBox.Text,
                            manufacturerBox.Text,
                            Convert.ToDouble(priceBox.Text),
                            descriptionBox.Text,
                            Convert.ToUInt32(countBox.Text),
                            Convert.ToUInt32(supplyPowerBox.Text)
                            );
                        break;
                    }
            }
            if (productToAdd != null)
            {
                Program.CatalogForm.addProductToCatalogList(productToAdd);
                MessageBox.Show("Товар додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                productToAdd.ProductID = productUtils.AddProduct(productToAdd);
                Close();
            }
            else MessageBox.Show("Не зміг додати новий продукт!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void editProduct()
        {
            if (!checkParams()) return;

            productUtils = new ProductUtils();
            Product productToUpdate = null;
            switch (categoryBox.Text)
            {
                case "CPU":
                    {
                        if (cpuCoresCountBox.Text == "" || cpuFrequencyBox.Text == "" || cpuSocketBox.Text == "")
                        {
                            MessageBox.Show("Вкажіть характеристики!", "Помилка", MessageBoxButtons.OK);
                            return;
                        }
                        productToUpdate = new CPU(
                            captionBox.Text,
                            manufacturerBox.Text,
                            Convert.ToDouble(priceBox.Text),
                            descriptionBox.Text,
                            Convert.ToUInt32(countBox.Text),
                            Convert.ToUInt32(cpuCoresCountBox.Text),
                            Convert.ToDouble(cpuFrequencyBox.Text),
                            cpuSocketBox.Text
                            );
                        break;
                    }
                case "Motherboard":
                    {
                        if (motherboardSocketBox.Text == "" || motherBoardChipsetBox.Text == "" || motherboardRamBox.Text == "")
                        {
                            MessageBox.Show("Вкажіть характеристики!", "Помилка", MessageBoxButtons.OK);
                            return;
                        }
                        productToUpdate = new Motherboard(
                            captionBox.Text,
                            manufacturerBox.Text,
                            Convert.ToDouble(priceBox.Text),
                            descriptionBox.Text,
                            Convert.ToUInt32(countBox.Text),
                            motherboardSocketBox.Text,
                            motherBoardChipsetBox.Text,
                            Convert.ToUInt32(motherboardRamBox.Text)
                            );
                        break;
                    }
                case "RAM":
                    {
                        if (ramCapacityBox.Text == "" || ramFrequencyBox.Text == "" || ramTypeBox.Text == "" || ramCountBox.Text == "")
                        {
                            MessageBox.Show("Вкажіть характеристики!", "Помилка", MessageBoxButtons.OK);
                            return;
                        }
                        productToUpdate = new RAM(
                            captionBox.Text,
                            manufacturerBox.Text,
                            Convert.ToDouble(priceBox.Text),
                            descriptionBox.Text,
                            Convert.ToUInt32(countBox.Text),
                            Convert.ToUInt32(ramCapacityBox.Text),
                            Convert.ToUInt32(ramFrequencyBox.Text),
                            (RAMType)ramTypeBox.SelectedItem,
                            Convert.ToUInt32(ramCountBox.Text)
                            );
                        break;
                    }
                case "GPU":
                    {
                        if (gpuPowerBox.Text == "" || gpuMemoryTypeBox.Text == "" || gpuMemoryCapacityBox.Text == "" || gpuInterfaceBox.Text == "")
                        {
                            MessageBox.Show("Вкажіть характеристики!", "Помилка", MessageBoxButtons.OK);
                            return;
                        }
                        productToUpdate = new GPU(
                            captionBox.Text,
                            manufacturerBox.Text,
                            Convert.ToDouble(priceBox.Text),
                            descriptionBox.Text,
                            Convert.ToUInt32(countBox.Text),
                            Convert.ToUInt32(gpuPowerBox.Text),
                            (GPUMemoryType)gpuMemoryTypeBox.SelectedItem,
                            Convert.ToUInt32(gpuMemoryCapacityBox.Text),
                            (GPUInterface)gpuInterfaceBox.SelectedItem
                            );
                        break;
                    }
                case "Drive":
                    {
                        if (driveCapacityBox.Text == "" || driveTypeBox.Text == "" || driveInterfaceBox.Text == "" || driveWriteBox.Text == "" || driveReadBox.Text == "")
                        {
                            MessageBox.Show("Вкажіть характеристики!", "Помилка", MessageBoxButtons.OK);
                            return;
                        }
                        productToUpdate = new Drive(
                            captionBox.Text,
                            manufacturerBox.Text,
                            Convert.ToDouble(priceBox.Text),
                            descriptionBox.Text,
                            Convert.ToUInt32(countBox.Text),
                            Convert.ToUInt32(driveCapacityBox.Text),
                            (DRIVEType)driveTypeBox.SelectedItem,
                            (DriveInterface)driveInterfaceBox.SelectedItem,
                            Convert.ToUInt32(driveWriteBox.Text),
                            Convert.ToUInt32(driveReadBox.Text)
                            );
                        break;
                    }
                case "Power Supply":
                    {
                        if (supplyPowerBox.Text == "")
                        {
                            MessageBox.Show("Вкажіть характеристики!", "Помилка", MessageBoxButtons.OK);
                            return;
                        }
                        productToUpdate = new PowerSupply(
                            captionBox.Text,
                            manufacturerBox.Text,
                            Convert.ToDouble(priceBox.Text),
                            descriptionBox.Text,
                            Convert.ToUInt32(countBox.Text),
                            Convert.ToUInt32(supplyPowerBox.Text)
                            );
                        break;
                    }
            }
            if (productToUpdate != null)
            {
                productToUpdate.ProductID = product.ProductID;
                productUtils.EditProduct(productToUpdate);
                Program.CatalogForm.updateProductInList(productToUpdate);
                MessageBox.Show("Товар відредаговано!");
                Close();
            }
            else MessageBox.Show("Не зміг оновити продукт!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addToCart()
        {
            if (textBoxCount.Text == "") { MessageBox.Show("Помилка кількості!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Convert.ToUInt32(textBoxCount.Text) > product.ProductCount) { MessageBox.Show("Такої кількості немає!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            IUserActions actions = Program.CatalogForm.user;
            actions.AddToCart(this.product.ProductID, Convert.ToUInt32(textBoxCount.Text));
            this.Close();
        }

        private void TableLayoutClear()
        {
            tableLayoutPanel.Controls.Clear();
        }

        private void cpuInitialize()
        {
            TableLayoutClear();

            for (int i = 0; i < 3; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tableLayoutPanel.RowCount++;
            }

            cpuCoresCount.Text = "Кількість ядер ";
            tableLayoutPanel.Controls.Add(cpuCoresCount, 0, 0);

            tableLayoutPanel.Controls.Add(cpuCoresCountBox, 1, 0);

            cpuFrequency.Text = "Частота (МГц)";
            tableLayoutPanel.Controls.Add(cpuFrequency, 0, 1);

            tableLayoutPanel.Controls.Add(cpuFrequencyBox, 1, 1);

            cpuSocket.Text = "Сокет";
            tableLayoutPanel.Controls.Add(cpuSocket, 0, 2);

            tableLayoutPanel.Controls.Add(cpuSocketBox, 1, 2);


            if (product != null)
            {
                CPU cpu = product as CPU;
                cpuCoresCountBox.Text = cpu.CPUCoresCount.ToString();
                cpuFrequencyBox.Text = cpu.CPUFrequency.ToString();
                cpuSocketBox.Text = cpu.CPUSocket;
            }
        }

        private void motherboardInitialize()
        {
            TableLayoutClear();

            for (int i = 0; i < 3; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tableLayoutPanel.RowCount++;
            }

            motherboardSocket.Text = "Сокет ";
            tableLayoutPanel.Controls.Add(motherboardSocket, 0, 0);

            tableLayoutPanel.Controls.Add(motherboardSocketBox, 1, 0);

            motherboardChipset.Text = "Чипсет";
            tableLayoutPanel.Controls.Add(motherboardChipset, 0, 1);

            tableLayoutPanel.Controls.Add(motherBoardChipsetBox, 1, 1);

            motherboardRam.Text = "Кількість слотів ОЗП";
            tableLayoutPanel.Controls.Add(motherboardRam, 0, 2);

            tableLayoutPanel.Controls.Add(motherboardRamBox, 1, 2);

            if (product != null)
            {
                Motherboard motherboard = product as Motherboard;
                motherboardSocketBox.Text = motherboard.MotherboardSocket;
                motherBoardChipsetBox.Text = motherboard.MotherboardChipset;
                motherboardRamBox.Text = motherboard.MotherboardRam.ToString();
            }
        }

        private void ramInitialize()
        {
            TableLayoutClear();

            for (int i = 0; i < 5; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tableLayoutPanel.RowCount++;
            }

            ramCapacity.Text = "Об'єм ГБ";
            tableLayoutPanel.Controls.Add(ramCapacity, 0, 0);

            tableLayoutPanel.Controls.Add(ramCapacityBox, 1, 0);

            ramFrequency.Text = "Частота (МГц)";
            tableLayoutPanel.Controls.Add(ramFrequency, 0, 1);

            tableLayoutPanel.Controls.Add(ramFrequencyBox, 1, 1);

            ramType.Text = "Тип ОЗП";
            tableLayoutPanel.Controls.Add(ramType, 0, 2);
            foreach (var item in Enum.GetValues(typeof(RAMType)))
                ramTypeBox.Items.Add(item);
            ramTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            tableLayoutPanel.Controls.Add(ramTypeBox, 1, 2);

            ramCount.Text = "Кількість модулів ОЗП";
            tableLayoutPanel.Controls.Add(ramCount, 0, 3);

            tableLayoutPanel.Controls.Add(ramCountBox, 1, 3);

            if (product != null)
            {
                RAM ram = product as RAM;
                ramCapacityBox.Text = ram.RAMCapacity.ToString();
                ramFrequencyBox.Text = ram.RAMFrequency.ToString();
                ramTypeBox.SelectedItem = ram.RAMType;
                ramCountBox.Text = ram.RAMCount.ToString();
            }
        }

        private void gpuInitialize()
        {
            TableLayoutClear();

            for (int i = 0; i < 4; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tableLayoutPanel.RowCount++;
            }

            gpuPower.Text = "Потужність ВТ";
            tableLayoutPanel.Controls.Add(gpuPower, 0, 0);

            tableLayoutPanel.Controls.Add(gpuPowerBox, 1, 0);

            gpuMemoryCapacity.Text = "Об'єм ГБ";
            tableLayoutPanel.Controls.Add(gpuMemoryCapacity, 0, 1);

            tableLayoutPanel.Controls.Add(gpuMemoryCapacityBox, 1, 1);

            gpuMemoryType.Text = "Тип пам'яті";
            tableLayoutPanel.Controls.Add(gpuMemoryType, 0, 2);
            foreach (var item in Enum.GetValues(typeof(GPUMemoryType)))
                gpuMemoryTypeBox.Items.Add(item);
            gpuMemoryTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            tableLayoutPanel.Controls.Add(gpuMemoryTypeBox, 1, 2);

            gpuInterface.Text = "Інтерфейс";
            foreach (var item in Enum.GetValues(typeof(GPUInterface)))
                gpuInterfaceBox.Items.Add(item);
            tableLayoutPanel.Controls.Add(gpuInterface, 0, 3);
            gpuInterfaceBox.DropDownStyle = ComboBoxStyle.DropDownList;
            tableLayoutPanel.Controls.Add(gpuInterfaceBox, 1, 3);


            if (product != null)
            {
                GPU gpu = product as GPU;
                gpuPowerBox.Text = gpu.GPUPower.ToString();
                gpuMemoryCapacityBox.Text = gpu.GPUMemoryCapacity.ToString();
                gpuMemoryTypeBox.SelectedItem = gpu.GPUMemoryType;
                gpuInterfaceBox.SelectedItem = gpu.GPUInterface;
            }
        }

        private void driveInitialize()
        {
            TableLayoutClear();

            for (int i = 0; i < 5; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tableLayoutPanel.RowCount++;
            }

            driveCapacity.Text = "Об'єм ГБ";
            tableLayoutPanel.Controls.Add(driveCapacity, 0, 0);

            tableLayoutPanel.Controls.Add(driveCapacityBox, 1, 0);

            driveType.Text = "Тип";
            tableLayoutPanel.Controls.Add(driveType, 0, 1);
            foreach (var item in Enum.GetValues(typeof(DRIVEType)))
                driveTypeBox.Items.Add(item);
            driveTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            tableLayoutPanel.Controls.Add(driveTypeBox, 1, 1);

            driveInterface.Text = "Інтерфейс";
            tableLayoutPanel.Controls.Add(driveInterface, 0, 2);
            foreach (var item in Enum.GetValues(typeof(DriveInterface)))
                driveInterfaceBox.Items.Add(item);
            driveInterfaceBox.DropDownStyle = ComboBoxStyle.DropDownList;
            tableLayoutPanel.Controls.Add(driveInterfaceBox, 1, 2);

            driveRead.Text = "Зчитування";
            tableLayoutPanel.Controls.Add(driveRead, 0, 3);

            tableLayoutPanel.Controls.Add(driveReadBox, 1, 3);

            driveWrite.Text = "Запис";
            tableLayoutPanel.Controls.Add(driveWrite, 0, 4);

            tableLayoutPanel.Controls.Add(driveWriteBox, 1, 4);

            if (product != null)
            {
                Drive drive = product as Drive;
                driveCapacityBox.Text = drive.DriveCapacity.ToString();
                driveTypeBox.SelectedItem = drive.DRIVEType;
                driveInterfaceBox.SelectedItem = drive.DriveInterface;
                driveReadBox.Text = drive.DriveRead.ToString();
                driveWriteBox.Text = drive.DriveWrite.ToString();
            }
        }

        private void powerSupplyInitialize()
        {
            TableLayoutClear();

            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanel.RowCount++;

            supplyPower.Text = "Потужність ВТ";
            tableLayoutPanel.Controls.Add(supplyPower, 0, 0);

            tableLayoutPanel.Controls.Add(supplyPowerBox, 1, 0);

            if (product != null)
            {
                PowerSupply powerSupply = product as PowerSupply;
                supplyPowerBox.Text = powerSupply.SupplyPower.ToString();
            }
        }

        private void categoryBox_TextChanged(object sender, EventArgs e)
        {
            switch (categoryBox.Text)
            {
                case "CPU":
                    {
                        cpuInitialize();
                        break;
                    }
                case "Motherboard":
                    {
                        motherboardInitialize();
                        break;
                    }
                case "RAM":
                    {
                        ramInitialize();
                        break;
                    }
                case "GPU":
                    {
                        gpuInitialize();
                        break;
                    }
                case "Drive":
                    {
                        driveInitialize();
                        break;
                    }
                case "Power Supply":
                    {
                        powerSupplyInitialize();
                        break;
                    }
            }
        }

        private void productPriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void countBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.StartsWith(","))
            {
                textBox.Text = textBox.Text.Substring(1);
                textBox.SelectionStart = 0;
            }

            if (textBox.Text.Contains(",,"))
            {
                textBox.Text = textBox.Text.Replace(",,", ",");
                textBox.SelectionStart = textBox.Text.LastIndexOf(",") + 1;
            }
        }
    }
}
