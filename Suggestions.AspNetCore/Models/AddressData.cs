using System.Collections.Generic;

namespace Suggestions.AspNetCore.Models
{
    public class AddressData
    {
        public string source { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }

        public string region_fias_id { get; set; }
        public string region_kladr_id { get; set; }
        public string region_with_type { get; set; }
        public string region_type { get; set; }
        public string region_type_full { get; set; }
        public string region { get; set; }

        public string area_fias_id { get; set; }
        public string area_kladr_id { get; set; }
        public string area_with_type { get; set; }
        public string area_type { get; set; }
        public string area_type_full { get; set; }
        public string area { get; set; }

        public string city_fias_id { get; set; }
        public string city_kladr_id { get; set; }
        public string city_with_type { get; set; }
        public string city_type { get; set; }
        public string city_type_full { get; set; }
        public string city { get; set; }

        public string city_area { get; set; }

        public string city_district_fias_id { get; set; }
        public string city_district_kladr_id { get; set; }
        public string city_district_with_type { get; set; }
        public string city_district_type { get; set; }
        public string city_district_type_full { get; set; }
        public string city_district { get; set; }

        public string settlement_fias_id { get; set; }
        public string settlement_kladr_id { get; set; }
        public string settlement_with_type { get; set; }
        public string settlement_type { get; set; }
        public string settlement_type_full { get; set; }
        public string settlement { get; set; }

        public string street_fias_id { get; set; }
        public string street_kladr_id { get; set; }
        public string street_with_type { get; set; }
        public string street_type { get; set; }
        public string street_type_full { get; set; }
        public string street { get; set; }

        public string house_fias_id { get; set; }
        public string house_kladr_id { get; set; }
        public string house_type { get; set; }
        public string house_type_full { get; set; }
        public string house { get; set; }

        public string block_type { get; set; }
        public string block_type_full { get; set; }
        public string block { get; set; }

        public string flat_type { get; set; }
        public string flat_type_full { get; set; }
        public string flat { get; set; }
        public string flat_area { get; set; }
        public string square_meter_price { get; set; }
        public string flat_price { get; set; }

        public string postal_box { get; set; }
        public string fias_id { get; set; }
        public string fias_level { get; set; }
        public string kladr_id { get; set; }
        public string capital_marker { get; set; }

        public string okato { get; set; }
        public string oktmo { get; set; }
        public string tax_office { get; set; }
        public string tax_office_legal { get; set; }

        public string timezone { get; set; }

        public string geo_lat { get; set; }
        public string geo_lon { get; set; }
        public string qc_geo { get; set; }

        public string beltway_hit { get; set; }
        public string beltway_distance { get; set; }

        public List<string> history_values { get; set; }

        public List<MetroData> metro { get; set; }
    }
}
