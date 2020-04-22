import { Routes } from "@angular/router";
import { HomeComponent } from "./home/home.component";
import { CreateAnEventComponent } from "./create-an-event/create-an-event.component";
import { ViewAllDjsComponent } from "./view-all-djs/view-all-djs.component";
import { EditProfileComponent } from "./edit-profile/edit-profile.component";
import { ViewBookingsComponent } from "./view-bookings/view-bookings.component";
import { ViewEventsComponent } from "./view-events/view-events.component";

export const appRoutes: Routes = [
  { path: "home", component: HomeComponent },
  { path: "create-an-event", component: CreateAnEventComponent },
  { path: "view-all-djs", component: ViewAllDjsComponent },
  { path: "edit-profile", component: EditProfileComponent },
  { path: "view-bookings", component: ViewBookingsComponent },
  { path: "view-events", component: ViewEventsComponent },
  { path: "**", redirectTo: "home", pathMatch: "full" },
];