import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment";
import { HttpClient } from "@angular/common/http";
import { CreateEvent } from "../_models/create-event";
import { Observable } from "rxjs";
import { Dj } from "../_models/dj";

@Injectable({
  providedIn: "root",
})
export class CreateEventService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  // [HttpPost("create/{promoterId}/{djId}")]
  //       public async Task<IActionResult> CreateEvent(int promoterId, int djId,
  //        Event ev)

  createEvent(promoterId, djId, ev: CreateEvent) {
    return this.http.post(
      this.baseUrl + "createevents/create/" + promoterId + "/" + djId,
      ev
    );
  }

  //[HttpGet("getorders/{promoterId}")]

  getPromoterOrders(promoterId) {
    return this.http.get(this.baseUrl + "createevents/getorders/" + promoterId);
  }

  // [HttpPost("cancel/{promoterId}")]
  //       public async Task<IActionResult> Cancel(int promoterId)

  cancelOrders(promoterId) {
    return this.http.delete(this.baseUrl + "createevents/cancel/" + promoterId);
  }

  // [HttpGet("avaliabledjs")]
  // public async Task<IActionResult> GetAvaliableDjs(Event evNew)

  getAvaliableDjs(evNew: CreateEvent): Observable<Dj[]> {
    return this.http.post<Dj[]>(
      this.baseUrl + "createevents/avaliabledjs",
      evNew
    );
  }

  // [HttpGet("shoppingexists/{promoterId}")]
  //       public async Task<bool> ShoppingExists(int promoterId)

  shoppingExists(promoterId) {
    return this.http.get(
      this.baseUrl + "createevents/shoppingexists/" + promoterId
    );
  }

  // getTotal(id) {
  //   return this.http.get(this.baseUrl + "createevents/gettotal/" + id);
  // }
}
