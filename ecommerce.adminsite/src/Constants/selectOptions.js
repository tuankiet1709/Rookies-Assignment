
import { useEffect, useState } from "react";

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

import { 
    CheckIsShowOnHome,
    CheckIsNotShowOnHome,
    CheckIsShowOnHomeLabel,
    CheckIsNotShowOnHomeLabel,
    CheckActive,
    CheckInActive,
    CheckActiveLabel,
    CheckInActiveLabel
} from "../Constants/Category/CategoryConstants";

import { 
    CheckIsFeatured,
    CheckIsFeaturedLabel,
    CheckIsNotFeatured,
    CheckIsNotFeaturedLabel
} from "../Constants/Product/ProductConstants";

export const isFeaturedProductOptions = [
    { id: 1, label: CheckIsFeaturedLabel, value: CheckIsFeatured },
    { id: 0, label: CheckIsNotFeaturedLabel, value: CheckIsNotFeatured },
];

export const isShowOnHomeOptions = [
    { id: 1, label: CheckIsShowOnHomeLabel, value: CheckIsShowOnHome },
    { id: 0, label: CheckIsNotShowOnHomeLabel, value: CheckIsNotShowOnHome },
];

export const checkActive = [
    { id: 1, label: CheckActive, value: CheckActiveLabel },
    { id: 0, label: CheckInActive, value: CheckInActiveLabel },
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
