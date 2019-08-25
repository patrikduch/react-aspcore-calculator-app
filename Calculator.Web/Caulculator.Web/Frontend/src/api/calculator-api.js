import { sendGet, sendPost } from './utils/request-utils';

import { rootPath } from './configuration-api'


export default class CalculatorApi {
    static getCalculations(successHandler, errorHandler) {
        return sendGet(rootPath+"Calculator/GetHistory", null, successHandler, errorHandler);
    }

    static postNewCalculations(data,successHandler, errorHandler) {
        return sendPost(rootPath+"Calculator/New/", data, successHandler, errorHandler);
    }
}