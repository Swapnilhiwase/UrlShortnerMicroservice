## Get Original Url

This API allows caller to get original long url , when caller provides the short url. If short URL is not present then caller will recive error.

### HTTP Request

```
POST /api/Url/getOrignalUrl
```

##### **Request Body**

#### Scenario 1 : Valid Input
This request will be sent for shortURL present into Database , user will recive the valid long URL.

```json
{
"shortUrl":"newgen.ly7s7488"
}
```

### HTTP Response

#### **Success**

```json
{
 "message": null,
    "longUrl": "https://github.com/Swapnilhiwase/UrlShortnerMicroservice/tree/master/UrlShortnerMicroservice",
    "shortUrl": "newgen.ly7s7488"
}
```