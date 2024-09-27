namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private List<Hotel> hotels;
        private List<Reservation> reservations;
        private bool isDarkTheme;

        public Form2()
        {

            InitializeComponent();
            InitializeHotels();
            SetupDataGridView();
            reservations = new List<Reservation>();
            SetupControls();
            ApplyLightTheme();

        }


        private void InitializeHotels()
        {

            hotels = new List<Hotel>();
            var hotelNames = new[]
            {

                "Солнце отель", "Гостиница в центре города", "Горный курорт",
                "Отель у пляжа", "Деревенский домик", "Дворец в центре",
                "Лесной укромный уголок", "Башни городского пейзажа",
                "Гранд отель", "Экологический Retreat", "Гостиница Городских Огней",
                "Сuites с видом на океан", "Люкс-вилла", "Шампанское отель",
                "Кедровый домик", "Речной пост", "Тропический курорт",
                "Люкс-убежище", "Старый Млин", "Морской Бунгало"
            };

            for (int i = 0; i < 300; i++)

            {

                string name = $"{hotelNames[i % hotelNames.Length]} {i + 1}";
                string description = $"Описание для {name}.";
                decimal price = 100 + (i % 10) * 10;
                hotels.Add(new Hotel(name, description, price));
            }
        }

        private void SetupDataGridView()

        {

            dataGridView1.Columns.Add("Name", "Название");
            dataGridView1.Columns.Add("Description", "Описание");
            dataGridView1.Columns.Add("Price", "Цена");

            foreach (var hotel in hotels)

            {

                dataGridView1.Rows.Add(hotel.Name, hotel.Description, hotel.Price);
            }
        }


        private void SetupControls()
        {

            Button btnToggleTheme = new Button();
            btnToggleTheme.Text = "Темная тема";
            btnToggleTheme.Location = new Point(10, 10);
            btnToggleTheme.Click += BtnToggleTheme_Click;
            Controls.Add(btnToggleTheme);

        }

        private void BtnToggleTheme_Click(object sender, EventArgs e)

        {

            if (isDarkTheme)
            {
                ApplyLightTheme();
            }
            else
            {
                ApplyDarkTheme();
            }
            isDarkTheme = !isDarkTheme;
        }

        private void ApplyLightTheme()

        {

            BackColor = Color.White;
            ForeColor = Color.Black;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.GridColor = Color.Black;

            foreach (Control control in Controls)
            {

                control.BackColor = Color.White;
                control.ForeColor = Color.Black;
            }
        }

        private void ApplyDarkTheme()
        {

            BackColor = Color.FromArgb(45, 45, 48);
            ForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.FromArgb(28, 28, 28);
            dataGridView1.ForeColor = Color.White;
            dataGridView1.GridColor = Color.White;

            foreach (Control control in Controls)

            {
                control.BackColor = Color.FromArgb(45, 45, 48);
                control.ForeColor = Color.White;
            }
        }

        private void z1_Click(object sender, EventArgs e)

        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                var selectedRow = dataGridView1.SelectedRows[0];
                string hotelName = selectedRow.Cells["Name"].Value.ToString();
                string hotelDescription = selectedRow.Cells["Description"].Value.ToString();
                decimal hotelPrice = (decimal)selectedRow.Cells["Price"].Value;

                MessageBox.Show($"Вы рассмотрели один из вариантов {hotelName}.\n" +
                                $"Описание: {hotelDescription}\n" +
                                $"Цена: {hotelPrice}$ за ночь", "Комната просмотрена");
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите отель из списка.", "Ошибка");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class Hotel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }

            public Hotel(string name, string description, decimal price)
            {
                Name = name;
                Description = description;
                Price = price;
            }

        }

        public class Reservation
        {
            public Hotel Hotel { get; set; }
            public DateTime CheckInDate { get; set; }
            public DateTime CheckOutDate { get; set; }
            public int NumGuests { get; set; }

            public Reservation(Hotel hotel, DateTime checkInDate, DateTime checkOutDate, int numGuests)
            {
                Hotel = hotel;
                CheckInDate = checkInDate;
                CheckOutDate = checkOutDate;
                NumGuests = numGuests;
            }
        }

        private void bratata_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedHotel = hotels.Find(h => h.Name == selectedRow.Cells["Name"].Value.ToString());

                DateTime checkInDate = d1.Value.Date;
                DateTime checkOutDate = d2.Value.Date;

                if (checkInDate >= checkOutDate)
                {
                    MessageBox.Show("Дата выезда должна быть позже даты заезда.", "Ошибка");
                    return;
                }

                int numGuests;
                if (!int.TryParse(gst.Text, out numGuests) || numGuests <= 0)
                {
                    MessageBox.Show("Введите корректное количество гостей.", "Ошибка");
                    return;
                }

                var reservation = new Reservation(selectedHotel, checkInDate, checkOutDate, numGuests);
                reservations.Add(reservation);

                MessageBox.Show($"Вы забронировали {reservation.Hotel.Name} с {reservation.CheckInDate.ToShortDateString()} по {reservation.CheckOutDate.ToShortDateString()} для {reservation.NumGuests} гостей.", "Бронирование успешно");
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите отель из списка.", "Ошибка");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string searchTerm = Psk.Text.ToLower();
            dataGridView1.Rows.Clear();

            foreach (var hotel in hotels)
            {

                if (hotel.Name.ToLower().Contains(searchTerm) || hotel.Description.ToLower().Contains(searchTerm))

                    dataGridView1.Rows.Add(hotel.Name, hotel.Description, hotel.Price);

            }

            if (dataGridView1.Rows.Count == 0)
            {

                MessageBox.Show("Отели не найдены.", "Результат поиска");
            }
        }

        private void PopulateReservationsListBox()
        {

            bron.Items.Clear();
            foreach (var reservation in reservations)
            {

                bron.Items.Add($"{reservation.Hotel.Name}, {reservation.CheckInDate.ToShortDateString()} - {reservation.CheckOutDate.ToShortDateString()}, Гостей: {reservation.NumGuests}");
            }
        }

        private void Psk_TextChanged(object sender, EventArgs e)
        {


            btnSearch_Click(sender, e);
        }

        private void btnbron_Click_1(object sender, EventArgs e)
        {

            PopulateReservationsListBox();
        }

        private void btnotz_Click(object sender, EventArgs e)
        {

            string feedback = txtOtz.Text;
            if (!string.IsNullOrWhiteSpace(feedback))
            {
                MessageBox.Show("Ваш отзыв отправлен: " + feedback, "Отзыв");
                txtOtz.Clear();
            }
            else
            {

                MessageBox.Show("Пожалуйста, введите ваш отзыв.", "Ошибка");
            }

            Controls.Add(btnotz);
        }

        private void RefreshHotelGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var hotel in hotels)
            {
                dataGridView1.Rows.Add(hotel.Name, hotel.Description, hotel.Price);
            }
        }


        private void btnprice1_Click(object sender, EventArgs e)
        {
            hotels = hotels.OrderBy(h => h.Price).ToList();
            RefreshHotelGrid();
        }

        private void btnprice2_Click(object sender, EventArgs e)
        {
            if (bron.SelectedItem != null)
            {
                string selectedReservation = bron.SelectedItem.ToString();
                var reservationToRemove = reservations.FirstOrDefault(r =>
                    selectedReservation.StartsWith(r.Hotel.Name));

                if (reservationToRemove != null)
                {
                    reservations.Remove(reservationToRemove);
                    MessageBox.Show("Резервирование отменено!", "Успех");
                    PopulateReservationsListBox();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите резервирование для отмены.", "Ошибка");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form2 = new Form3();
            form2.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}