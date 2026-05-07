
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum TaxType
    {
        /// <summary>
        /// 
        /// </summary>
        AeTrn,
        /// <summary>
        /// 
        /// </summary>
        AuAbn,
        /// <summary>
        /// 
        /// </summary>
        AuArn,
        /// <summary>
        /// 
        /// </summary>
        BrCnpj,
        /// <summary>
        /// 
        /// </summary>
        BrCpf,
        /// <summary>
        /// 
        /// </summary>
        CaBn,
        /// <summary>
        /// 
        /// </summary>
        CaGstHst,
        /// <summary>
        /// 
        /// </summary>
        CaPstBc,
        /// <summary>
        /// 
        /// </summary>
        CaPstMb,
        /// <summary>
        /// 
        /// </summary>
        CaPstSk,
        /// <summary>
        /// 
        /// </summary>
        CaQst,
        /// <summary>
        /// 
        /// </summary>
        ChVat,
        /// <summary>
        /// 
        /// </summary>
        ClTin,
        /// <summary>
        /// 
        /// </summary>
        EsCif,
        /// <summary>
        /// 
        /// </summary>
        EuVat,
        /// <summary>
        /// 
        /// </summary>
        GbVat,
        /// <summary>
        /// 
        /// </summary>
        GeVat,
        /// <summary>
        /// 
        /// </summary>
        HkBr,
        /// <summary>
        /// 
        /// </summary>
        IdNpwp,
        /// <summary>
        /// 
        /// </summary>
        IlVat,
        /// <summary>
        /// 
        /// </summary>
        InGst,
        /// <summary>
        /// 
        /// </summary>
        JpCn,
        /// <summary>
        /// 
        /// </summary>
        JpRn,
        /// <summary>
        /// 
        /// </summary>
        KrBrn,
        /// <summary>
        /// 
        /// </summary>
        LiUid,
        /// <summary>
        /// 
        /// </summary>
        MxRfc,
        /// <summary>
        /// 
        /// </summary>
        MyFrp,
        /// <summary>
        /// 
        /// </summary>
        MyItn,
        /// <summary>
        /// 
        /// </summary>
        MySst,
        /// <summary>
        /// 
        /// </summary>
        NoVat,
        /// <summary>
        /// 
        /// </summary>
        NzGst,
        /// <summary>
        /// 
        /// </summary>
        RuInn,
        /// <summary>
        /// 
        /// </summary>
        RuKpp,
        /// <summary>
        /// 
        /// </summary>
        SaVat,
        /// <summary>
        /// 
        /// </summary>
        SgGst,
        /// <summary>
        /// 
        /// </summary>
        SgUen,
        /// <summary>
        /// 
        /// </summary>
        ThVat,
        /// <summary>
        /// 
        /// </summary>
        TwVat,
        /// <summary>
        /// 
        /// </summary>
        UaVat,
        /// <summary>
        /// 
        /// </summary>
        UsEin,
        /// <summary>
        /// 
        /// </summary>
        ZaVat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaxTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaxType value)
        {
            return value switch
            {
                TaxType.AeTrn => "ae_trn",
                TaxType.AuAbn => "au_abn",
                TaxType.AuArn => "au_arn",
                TaxType.BrCnpj => "br_cnpj",
                TaxType.BrCpf => "br_cpf",
                TaxType.CaBn => "ca_bn",
                TaxType.CaGstHst => "ca_gst_hst",
                TaxType.CaPstBc => "ca_pst_bc",
                TaxType.CaPstMb => "ca_pst_mb",
                TaxType.CaPstSk => "ca_pst_sk",
                TaxType.CaQst => "ca_qst",
                TaxType.ChVat => "ch_vat",
                TaxType.ClTin => "cl_tin",
                TaxType.EsCif => "es_cif",
                TaxType.EuVat => "eu_vat",
                TaxType.GbVat => "gb_vat",
                TaxType.GeVat => "ge_vat",
                TaxType.HkBr => "hk_br",
                TaxType.IdNpwp => "id_npwp",
                TaxType.IlVat => "il_vat",
                TaxType.InGst => "in_gst",
                TaxType.JpCn => "jp_cn",
                TaxType.JpRn => "jp_rn",
                TaxType.KrBrn => "kr_brn",
                TaxType.LiUid => "li_uid",
                TaxType.MxRfc => "mx_rfc",
                TaxType.MyFrp => "my_frp",
                TaxType.MyItn => "my_itn",
                TaxType.MySst => "my_sst",
                TaxType.NoVat => "no_vat",
                TaxType.NzGst => "nz_gst",
                TaxType.RuInn => "ru_inn",
                TaxType.RuKpp => "ru_kpp",
                TaxType.SaVat => "sa_vat",
                TaxType.SgGst => "sg_gst",
                TaxType.SgUen => "sg_uen",
                TaxType.ThVat => "th_vat",
                TaxType.TwVat => "tw_vat",
                TaxType.UaVat => "ua_vat",
                TaxType.UsEin => "us_ein",
                TaxType.ZaVat => "za_vat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaxType? ToEnum(string value)
        {
            return value switch
            {
                "ae_trn" => TaxType.AeTrn,
                "au_abn" => TaxType.AuAbn,
                "au_arn" => TaxType.AuArn,
                "br_cnpj" => TaxType.BrCnpj,
                "br_cpf" => TaxType.BrCpf,
                "ca_bn" => TaxType.CaBn,
                "ca_gst_hst" => TaxType.CaGstHst,
                "ca_pst_bc" => TaxType.CaPstBc,
                "ca_pst_mb" => TaxType.CaPstMb,
                "ca_pst_sk" => TaxType.CaPstSk,
                "ca_qst" => TaxType.CaQst,
                "ch_vat" => TaxType.ChVat,
                "cl_tin" => TaxType.ClTin,
                "es_cif" => TaxType.EsCif,
                "eu_vat" => TaxType.EuVat,
                "gb_vat" => TaxType.GbVat,
                "ge_vat" => TaxType.GeVat,
                "hk_br" => TaxType.HkBr,
                "id_npwp" => TaxType.IdNpwp,
                "il_vat" => TaxType.IlVat,
                "in_gst" => TaxType.InGst,
                "jp_cn" => TaxType.JpCn,
                "jp_rn" => TaxType.JpRn,
                "kr_brn" => TaxType.KrBrn,
                "li_uid" => TaxType.LiUid,
                "mx_rfc" => TaxType.MxRfc,
                "my_frp" => TaxType.MyFrp,
                "my_itn" => TaxType.MyItn,
                "my_sst" => TaxType.MySst,
                "no_vat" => TaxType.NoVat,
                "nz_gst" => TaxType.NzGst,
                "ru_inn" => TaxType.RuInn,
                "ru_kpp" => TaxType.RuKpp,
                "sa_vat" => TaxType.SaVat,
                "sg_gst" => TaxType.SgGst,
                "sg_uen" => TaxType.SgUen,
                "th_vat" => TaxType.ThVat,
                "tw_vat" => TaxType.TwVat,
                "ua_vat" => TaxType.UaVat,
                "us_ein" => TaxType.UsEin,
                "za_vat" => TaxType.ZaVat,
                _ => null,
            };
        }
    }
}