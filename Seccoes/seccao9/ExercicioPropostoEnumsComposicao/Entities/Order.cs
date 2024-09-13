using ExercicioPropostoEnumsComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoEnumsComposicao.Entities {
    internal class Order {
        public DateTime Moment {  get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item) {
            Items.Add(item);
            
        }
        public void removeItem(OrderItem item) { 
            Items.Remove(item);
        }
        public double total() {
            double valorTotal = 0.0;
            foreach (OrderItem item in Items) {
                valorTotal += item.SubTotal();
            }
            return valorTotal;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
                sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
                sb.AppendLine("Order status: " + Status);
                sb.AppendLine("Client: " + Client.Name + " (" + Client.Date + ") - " + Client.Email);
                foreach (OrderItem item in Items) {
                    sb.AppendLine(item.ToString());
                }
                sb.AppendLine("Total price $" + total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
            }
        }
    }

