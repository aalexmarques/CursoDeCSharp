using System;
using System.Collections.Generic;
using System.Text;

namespace EnumeracoesIntroducao.Entities.Enums {
     enum OrderStatus : int { //cada valor do meu order status vai ser to tipo inteiro
                              // esta syntax dos ":" vou apredner melhor no cpatiulo sobre herança
                              // é derivado do tipo base que é um int
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered =3


    }
}
