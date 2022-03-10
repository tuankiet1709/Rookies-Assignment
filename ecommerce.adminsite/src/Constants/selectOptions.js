import {
    Yes,
    No 
} from "../Constants/Product/ProductConstants";

import { 
    NormalBrandType, 
    LuxuryBrandType,
    AllBrandType,
    NormalBrandTypeLabel,
    LuxyryBrandTypeLabel,
    AllBrandTypeLabel
} from "../Constants/Brand/BrandConstants";

export const isFeaturedProductOptions = [
    { id: 1, label: Yes, value: Yes },
    { id: 2, label: No, value: No },
];

export const BrandTypeOptions = [
    { id: 1, label: NormalBrandTypeLabel, value: NormalBrandType },
    { id: 2, label: LuxyryBrandTypeLabel, value: LuxuryBrandType },
];

export const FilterBrandTypeOptions = [
    { id: 1, label: AllBrandTypeLabel, value: AllBrandType },
    { id: 2, label: NormalBrandTypeLabel, value: NormalBrandType },
    { id: 3, label: LuxyryBrandTypeLabel, value: LuxuryBrandType },
];
