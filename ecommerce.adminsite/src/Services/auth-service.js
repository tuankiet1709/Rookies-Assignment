import { UserManager } from "oidc-client";
import { CallBackEndpoints, UrlBackEnd } from "../constants/oidc-configs";
const oidcSettings = {
    authority: UrlBackEnd,
    client_id: "admin",
    redirect_uri: CallBackEndpoints.redirect_uri,
    post_logout_redirect_uri: CallBackEndpoints.post_logout_redirect_uri,
    response_type: "id_token token",
    scope: "ecommerce.api openid profile offline_access",
    automaticSilentRenew: true,
    includeIdTokenInSilentRenew: true,
};
class AuthService {
    constructor() {
        this.userManager = new UserManager(oidcSettings);
    }
    getUserAsync() {
        return this.userManager.getUser();
    }
    loginAsync() {
        return this.userManager.signinRedirect({
            state: window.location.hash,
        });
    }
    completeLoginAsync(url) {
        return this.userManager.signinRedirectCallback(url);
    }
    renewTokenAsync() {
        return this.userManager.signinSilent();
    }
    logoutAsync() {
        return this.userManager.signoutRedirect();
    }
    async completeLogoutAsync(url) {
        await this.userManager.signoutRedirectCallback(url);
    }
}
export default new AuthService();