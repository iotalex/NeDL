import { OnInit } from "@angular/core";

export class MyListComponent implements OnInit {
  ngOnInit(): void {
    throw new Error("Method not implemented.");
  }
  shoppingList: ShoppingListItem[] | undefined;

  
}

export interface ShoppingListItem {
  title: string;
}
export class BackendService {
  constructor() {}

  async shoppingList(): Promise<ShoppingListItem[]> {
    return new Promise((resolve) => {
      resolve([
        { title: 'Milk' },
        { title: 'Eggs' },
        { title: 'Stick of Butter' },
      ] as ShoppingListItem[]);
    });
  }
}


