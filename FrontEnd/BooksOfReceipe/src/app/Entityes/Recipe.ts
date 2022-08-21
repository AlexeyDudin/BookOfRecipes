import { TagClass } from "./TagClass";

export class Recipe {
    title: string = "";
    text: string = "";
    imagePath: string = "";
    likeCount: number = 0;
    timer: number = 0;
    persons: number = 0;
    tags: TagClass [] = [
        {
            text : ""
        }];
    }