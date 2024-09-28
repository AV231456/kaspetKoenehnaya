namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public class Room
        {
            public string RoomNumber { get; set; }
            public string Code { get; set; }
        }

        public class Excursion
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
        }

        public class Promotion
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime ExpirationDate { get; set; }
        }

        public class Service
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public class BookingHistory
        {
            public List<string> BookedRooms { get; set; } = new List<string>();
            public List<string> OrdersHistory { get; set; } = new List<string>();
            public List<string> ServicesHistory { get; set; } = new List<string>();

            public void AddRoomToHistory(string room)
            {
                BookedRooms.Add(room);
            }

            public void AddOrderToHistory(string order)
            {
                OrdersHistory.Add(order);
            }

            public void AddServiceToHistory(string service)
            {
                ServicesHistory.Add(service);
            }
        }

        public class Event
        {
            public string Title { get; set; }
            public DateTime Date { get; set; }
            public string Description { get; set; }
        }

        private List<string> orders;
        private List<Room> rooms;
        private List<Excursion> excursions;
        private List<Promotion> promotions;
        private List<Service> services;
        private BookingHistory bookingHistory;
        private List<Event> events;

        public Form3()
        {
            InitializeComponent();

            orders = new List<string>();
            rooms = new List<Room>
            {
                new Room { RoomNumber = "801", Code = "1234" },
                new Room { RoomNumber = "802", Code = "2345" },
                new Room { RoomNumber = "803", Code = "3456" },
                new Room { RoomNumber = "804", Code = "4567" },
                new Room { RoomNumber = "805", Code = "5678" }
            };

            excursions = new List<Excursion>
            {
                new Excursion { Name = "Гид по городу", Description = "2-часовая экскурсия по основным достопримечательностям города.", Price = 20m },
                new Excursion { Name = "Поездка на озеро", Description = "Однодневная поездка на живописное озеро с возможностью купания.", Price = 50m },
                new Excursion { Name = "Кулинарный тур", Description = "Познакомьтесь с местной кухней в лучших ресторанах города.", Price = 30m }
            };

            promotions = new List<Promotion>
            {
                new Promotion { Title = "Скидка 20%", Description = "Скидка действует до конца месяца.", ExpirationDate = DateTime.Now.AddDays(30) },
                new Promotion { Title = "Бесплатный завтрак при бронировании номера", Description = "Предложение действительно.", ExpirationDate = DateTime.Now.AddDays(15) }
            };

            services = new List<Service>
            {
                new Service { Name = "Бизнес-центр", Description = "Полностью оборудованный бизнес-центр." },
                new Service { Name = "Спортзал", Description = "Современный спортзал с тренажерами." },
                new Service { Name = "Бассейн", Description = "Открытый бассейн с подогревом." },
                new Service { Name = "Ресторан", Description = "Ресторан с разнообразным меню." }
            };

            bookingHistory = new BookingHistory();

            events = new List<Event>
            {
                new Event { Title = "Мастер-класс по кулинарии", Date = DateTime.Now.AddDays(5), Description = "Даты: 2 октября 2024 г. Время: 18:00." },
                new Event { Title = "Вечеринка у бассейна", Date = DateTime.Now.AddDays(10), Description = "Даты: 7 октября 2024 г. Время: 19:00." },
                new Event { Title = "Гид по городу", Date = DateTime.Now.AddDays(12), Description = "Даты: 9 октября 2024 г. Время: 10:00." },
            
            };

            boxYcl.Items.AddRange(new string[] { "Еда", "Напитки", "Услуги" });

            dataGridView1.DataSource = rooms;

            dataGridView1.Columns[0].HeaderText = "Номер комнаты";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14);
            dataGridView1.RowTemplate.Height = 40;

            PopulateExcursions();
            PopulatePromotions();
            PopulateServices();
            PopulateEvents();
        }

        private void PopulateExcursions()
        {
            foreach (var excursion in excursions)
            {

                listBoxzakaz.Items.Add($"{excursion.Name} - {excursion.Description} (Цена: {excursion.Price} ₽)");
            }
        }

        private void PopulatePromotions()
        {
            foreach (var promotion in promotions)
            {
                listBoxPromotions.Items.Add($"{promotion.Title} - {promotion.Description} (Действует до: {promotion.ExpirationDate.ToShortDateString()})");
            }
        }

        private void PopulateServices()
        {
            foreach (var service in services)
            {
                listBoxServices.Items.Add($"{service.Name} - {service.Description}");
            }
        }

        private void PopulateEvents()
        {
            
            foreach (var evt in events)
            {
                lstPop.Items.Add($"{evt.Title} - {evt.Description} (Дата: {evt.Date.ToShortDateString()})");
            }
        }

        private void btnYcl_Click(object sender, EventArgs e)
        {
            string category = boxYcl.SelectedItem?.ToString();
            string item = txtYcl.Text;
            string room = txtYcl2.Text;

            if (string.IsNullOrEmpty(category) || string.IsNullOrEmpty(item) || string.IsNullOrEmpty(room) || !IsRoomValid(room))
            {

                MessageBox.Show("Пожалуйста, выберите категорию, введите наименование заказа и номер комнаты, которая доступна в списке.");
                return;
            }

            string order = $"{DateTime.Now.ToShortTimeString()}: {category} - {item} (Комната: {room})";
            orders.Add(order);
            Check.Items.Add(order);

            bookingHistory.AddOrderToHistory(order);

            TimeSpan deliveryTime = TimeSpan.FromMinutes(15);
            DateTime deliveryDateTime = DateTime.Now.Add(deliveryTime);
            MessageBox.Show($"Ваш заказ будет доставлен в комнату {room} в {deliveryDateTime.ToShortTimeString()}", "Уведомление о доставке");

            txtYcl.Clear();
            txtYcl2.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string roomNumber = txtOtkr.Text;
            string accessCode = txtSmart.Text;

            Room room = rooms.Find(r => r.RoomNumber == roomNumber);
            if (room != null)
            {

                if (room.Code == accessCode)
                {
                    MessageBox.Show($"Дверь комнаты {roomNumber} открыта!", "Успех");

                    bookingHistory.AddRoomToHistory(roomNumber);
                }
                else
                {
                    MessageBox.Show("Неверный код доступа. Попробуйте еще раз.", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Комната не найдена.", "Ошибка");
            }
        }

        private bool IsRoomValid(string room)
        {
            return rooms.Any(r => r.RoomNumber == room);
        }

        private void listBoxzakaz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxzakaz.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите экскурсию для заказа.");
                return;
            }

            string selectedExcursion = listBoxzakaz.SelectedItem.ToString();

            MessageBox.Show($"Вы успешно заказали: {selectedExcursion}", "Заказ экскурсии");

            bookingHistory.AddServiceToHistory(selectedExcursion);
        }

        private void btnDeleteOrder_Click_1(object sender, EventArgs e)
        {
            if (Check.SelectedItem == null)
            {

                MessageBox.Show("Пожалуйста, выберите заказ для удаления.");
                return;
            }

            string selectedOrder = Check.SelectedItem.ToString();
            orders.Remove(selectedOrder);
            Check.Items.Remove(selectedOrder);
            MessageBox.Show("Заказ успешно удален.", "Удаление заказа");
        }

        private void btnhis_Click(object sender, EventArgs e)
        {
            string historyMessage = "История Бронирований:\n\n";

            historyMessage += "Забронированные Комнаты:\n";
            foreach (var room in bookingHistory.BookedRooms)
            {

                historyMessage += $"- {room}\n";
            }

            historyMessage += "\nИстория Заказов:\n";
            foreach (var order in bookingHistory.OrdersHistory)
            {

                historyMessage += $"- {order}\n";
            }

            historyMessage += "\nИстория Услуг:\n";
            foreach (var service in bookingHistory.ServicesHistory)
            {
                historyMessage += $"- {service}\n";
            }

            MessageBox.Show(historyMessage, "История Бронирований");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string eventMessage = "Предстоящие мероприятия:\n\n";

            foreach (var evt in events)
            {
                eventMessage += $"{evt.Title} - {evt.Description} (Дата: {evt.Date.ToShortDateString()})\n";
            }

            MessageBox.Show(eventMessage, "Календарь мероприятий");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

