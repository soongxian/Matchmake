using MediatR;

namespace JodohFinder.Voucher.UseCase
{
    public class AddVoucherCommand : IRequest<List<VoucherDTO>>
    {
        public int Count { get; set; }
        public Guid Voucher_CreBy
        {
            get; set;
        }
    }
}
