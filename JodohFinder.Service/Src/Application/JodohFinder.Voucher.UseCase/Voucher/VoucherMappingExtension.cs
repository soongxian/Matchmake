using JodohFinder.Domain;

namespace JodohFinder.Voucher.UseCase
{
    public static class VoucherMappingExtension
    {
        public static VoucherDTO JF_VoucherToDto(this JF_VOUCHER voucher)
        {
            return new VoucherDTO
            {
                VOUCHER_ID = voucher.VOUCHER_ID,
                VOUCHER_CODE = voucher.VOUCHER_CODE,
                VOUCHER_CREDATE = voucher.VOUCHER_CREDATE,
                VOUCHER_CREBY = voucher.VOUCHER_CREBY,
                VOUCHER_USEDATE = voucher.VOUCHER_USEDATE,
                VOUCHER_ISUSED = voucher.VOUCHER_ISUSED
            };
        }

        public static List<VoucherDTO> JF_VoucherListToDto(this List<JF_VOUCHER> vouchers)
        {
            return vouchers.Select(v => v.JF_VoucherToDto()).ToList();
        }
    }
}
