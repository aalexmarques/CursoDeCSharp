using System;
using System.Globalization;
using EnumeracoesIntroducao.Entities.Enums;

namespace EnumeracoesIntroducao.Entities {
    class Order {
        public int Id { get; set; }
        public DateTime Moment {  get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString() {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
                
        }

    }
}
