export interface IMenuItem {
    caption: string;
    iconName: string;
    customClasses?: string[];
    onClickEvent?: string;
    routeLink?: string;
}