import { Injectable } from '@angular/core';
export class MyListComponent implements OnInit {
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


