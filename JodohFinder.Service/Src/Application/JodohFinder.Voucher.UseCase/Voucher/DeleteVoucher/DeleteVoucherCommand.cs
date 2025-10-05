using MediatR;

namespace JodohFinder.Voucher.UseCase
{
    public class DeleteVoucherCommand : IRequest<List<VoucherDTO>>
    {
        public List<Guid> VoucherId { get; set; } = new List<Guid>();
    }
}
