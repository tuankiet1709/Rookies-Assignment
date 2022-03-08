import axios, {AxiosInstance, AxiosRequestConfig} from "axios";
import { UrlBackend } from "../Constants/oidc-config";

const config = {
    baseUrl: UrlBackend
}

class RequestService{
    axios;

    constructor(){
        this.axios=axios.create(config);
    }

    setAuthentication(accessToken){
        this.axios.defaults.headers.common['Authorization']=`Bearer ${accessToken};`
    }
}

export default new RequestService();