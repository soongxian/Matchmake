using MediatR;

namespace JodohFinder.Voucher.UseCase
{
    public class GetVoucherQuery : IRequest<List<VoucherDTO>>
    {
        public Guid? VoucherId { get; set; }
        public int? VoucherIsUsed { get; set; }
        public Guid? CreatedBy { get; set; }
    }
}
