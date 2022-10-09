using System.Text.Json.Serialization;

namespace SV.Techorama.Models;

public record RdwModel
{
    [JsonPropertyName("kenteken")]
    public string LicensePlate { get; init; } = null!;

    [JsonPropertyName("merk")]
    public string Brand { get; init; } = null!;

    [JsonPropertyName("handelsbenaming")] 
    public string Model { get; init; } = null!;

    [JsonPropertyName("vervaldatum_apk")]
    public string ApkExpiryDate { get; init; } = null!;

    [JsonPropertyName("datum_tenaamstelling")]
    public string AscriptionDate { get; init; } = null!;

    [JsonPropertyName("datum_eerste_toelating")]
    public string InitialRegistrationDate { get; init; } = null!;

    [JsonPropertyName("eerste_kleur")]
    public string Color { get; init; } = null!;

    [JsonPropertyName("massa_ledig_voertuig")]
    public string EmptyWeight { get; init; } = null!;

    [JsonPropertyName("maximale_constructiesnelheid")]
    public string MaximumSpeed { get; init; } = null!;

    [JsonPropertyName("lengte")]
    public string Length { get; init; } = null!;

    [JsonPropertyName("breedte")]
    public string Width { get; init; } = null!;

    [JsonPropertyName("hoogte_voertuig")]
    public string Height { get; init; } = null!;

}

/*
[
    {
        "kenteken": "R759BK",
        "voertuigsoort": "Personenauto",
        "merk": "OPEL",
        "handelsbenaming": "CORSA",
        "vervaldatum_apk": "20260725",
        "datum_tenaamstelling": "20220725",
        "inrichting": "hatchback",
        "aantal_zitplaatsen": "5",
        "eerste_kleur": "ORANJE",
        "tweede_kleur": "Niet geregistreerd",
        "massa_ledig_voertuig": "1430",
        "toegestane_maximum_massa_voertuig": "1920",
        "massa_rijklaar": "1530",
        "datum_eerste_toelating": "20220725",
        "datum_eerste_tenaamstelling_in_nederland": "20220725",
        "wacht_op_keuren": "Geen verstrekking in Open Data",
        "catalogusprijs": "30999",
        "wam_verzekerd": "Ja",
        "maximale_constructiesnelheid": "150",
        "aantal_deuren": "4",
        "aantal_wielen": "4",
        "afstand_hart_koppeling_tot_achterzijde_voertuig": "0",
        "afstand_voorzijde_voertuig_tot_hart_koppeling": "0",
        "lengte": "406",
        "breedte": "175",
        "europese_voertuigcategorie": "M1",
        "technische_max_massa_voertuig": "1920",
        "type": "U",
        "typegoedkeuringsnummer": "e2*2007/46*0639*18",
        "variant": "H",
        "uitvoering": "ZKXZ-X0C000",
        "volgnummer_wijziging_eu_typegoedkeuring": "0",
        "vermogen_massarijklaar": "0.04",
        "wielbasis": "254",
        "export_indicator": "Nee",
        "openstaande_terugroepactie_indicator": "Nee",
        "taxi_indicator": "Nee",
        "maximum_massa_samenstelling": "0",
        "aantal_rolstoelplaatsen": "0",
        "maximum_ondersteunende_snelheid": "0.00",
        "jaar_laatste_registratie_tellerstand": "2022",
        "tellerstandoordeel": "Logisch",
        "code_toelichting_tellerstandoordeel": "00",
        "tenaamstellen_mogelijk": "Ja",
        "vervaldatum_apk_dt": "2026-07-25T00:00:00.000",
        "datum_tenaamstelling_dt": "2022-07-25T00:00:00.000",
        "datum_eerste_toelating_dt": "2022-07-25T00:00:00.000",
        "datum_eerste_tenaamstelling_in_nederland_dt": "2022-07-25T00:00:00.000",
        "hoogte_voertuig": "144",
        "registratie_datum_goedkeuring_afschrijvingsmoment_bpm": "20220715",
        "registratie_datum_goedkeuring_afschrijvingsmoment_bpm_dt": "2022-07-15T00:00:00.000",
        "api_gekentekende_voertuigen_assen": "https://opendata.rdw.nl/resource/3huj-srit.json",
        "api_gekentekende_voertuigen_brandstof": "https://opendata.rdw.nl/resource/8ys7-d773.json",
        "api_gekentekende_voertuigen_carrosserie": "https://opendata.rdw.nl/resource/vezc-m2t6.json",
        "api_gekentekende_voertuigen_carrosserie_specifiek": "https://opendata.rdw.nl/resource/jhie-znh9.json",
        "api_gekentekende_voertuigen_voertuigklasse": "https://opendata.rdw.nl/resource/kmfi-hrps.json"
    }
]
*/
