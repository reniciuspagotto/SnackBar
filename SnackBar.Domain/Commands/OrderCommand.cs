using System.Collections.Generic;

namespace SnackBar.Domain.Commands
{
    public class OrderCommand
    {
        public List<OrderSnackCommand> Snacks { get; set; }
    }
}
