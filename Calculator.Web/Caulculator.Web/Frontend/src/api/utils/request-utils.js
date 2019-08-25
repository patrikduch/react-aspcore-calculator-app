import axios from 'axios';

export function sendGet(url, responseType = 'json') {
    return axios.get(
        (url),
        responseType = responseType

    );
};
  
export function sendPost(url,data,responseType = 'json') {
    return axios.post(
        (url),
        data,
        responseType = responseType
    );
};
  