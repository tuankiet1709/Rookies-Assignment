import { AxiosResponse } from "axios";
import qs from 'qs';

import RequestService from '../../../services/request';
import EndPoints from '../../../Constants/endpoints';

export function getCustomersRequest(query) {
    return RequestService.axios.get(EndPoints.customer, {
        params: query,
        paramsSerializer: params => qs.stringify(params),
    });
}
