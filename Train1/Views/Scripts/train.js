var app = angular.module("fameCinemaApp", []);
app.controller("BehaviourController", function ($scope) {
    this.persistedSelections = [];
    this.seats = [];
    this.row = 5;
    this.col = 5;

    var self = this;
    this.init = function () {
        this.showWelcomeText = true;
        this.showCategories = false;
        this.showNameInput = false;
        this.showTicketQtyInput = false;
        this.mainText = "Welcome! Would you like to book a ticket?";
        this.buttonText = "Yes!";
        this.name = undefined;
        this.count = undefined;
        this.selected = [];

        this.buildSeatMap();
    };

    this.nextStep = function () {
        this.buttonText = "Next";
        if (undefined === this.name) {
            this.mainText = "Okay, please tell us your name";
            toggleInput(self, "name");
        } else if (undefined === this.count) {
            // user has already input name. Show greeting
            this.mainText = "Hi " + this.name + "! Please enter the number of tickets you wish to buy";
            toggleInput(self, "count");
            this.buttonText = "Show me seats!";
        } else if (0 == this.selected.length) {

            this.showWelcomeText = false;
            this.mainText = "Fantastic! Now " + this.name + ", Please choose your seats";
            toggleInput(self);
            if (!this.showCategories) {
                this.showCategories = true;
            } else {
                this.showCategories = false;
            }
            this.buttonText = "Confirm my booking!";
        } else if (this.count >= this.selected.length) {
            // save and flush
            var saveSelectionObject = {
                "name": this.name,
                "count": this.selected.length,
                "seats": this.selected
            };
            for (var i = 0; i < this.selected.length; i++) {
                var seat = this.selected[i];
                var seatIndex = this.getSeatIndex(seat);
                this.seats[seatIndex].old = true;
            }
            this.persistedSelections.push(saveSelectionObject);
            this.init();
        }

    };
    var toggleInput = function (self, input) {
        self.showNameInput = false;
        self.showTicketQtyInput = false;
        if ("name" === input) {
            self.showNameInput = true;
        } else if ("count" === input) {
            self.showTicketQtyInput = true;
        }
    };
    this.getSeatIndex = function (seat) {
        var seatIndex = _.findIndex(this.seats, {
            'name': seat
        });
        return seatIndex;
    };
    this.deSelect = function (seat) {
        var seatIndex = this.getSeatIndex(seat);
        this.seats[seatIndex].reserved = false;
        //var buffer = this.selected;
        //this.selected = [];
        var index;
        for (var i = 0; i < this.selected.length; i++) {
            if (this.selected[i] == seat) {
                index = i;
            }
        }
        this.selected.splice(index, 1);
    };
    this.select = function (seat) {
        var flag = false;
        if (undefined != this.selected.length) {
            if (this.selected.length < this.count) {
                flag = true;
            }
            for (var i = 0; i < this.selected.length; i++) {
                if (this.selected[i] == seat) {
                    flag = false;
                    this.deSelect(seat);
                    break;
                }
            }
        } else {
            flag = true;
        }
        var seatIndex = this.getSeatIndex(seat);
        if (this.seats[seatIndex].reserved) {
            flag = false;
        }
        if (flag) {
            this.selected.push(seat);
            this.seats[seatIndex].reserved = true;
        }
    };
    this.buildSeatMap = function () {
        if (this.seats.length == 0) {

            for (var i = 1; i <= this.row; i++) {
                for (var j = 1; j <= this.col; j++) {
                    var newLine = (j == this.col);
                    var name = "S" + i + j;
                    var seat = {
                        "id": i + j,
                        "name": name,
                        "reserved": false,
                        "old": false,
                        "newLine": newLine
                    };
                    this.seats.push(seat);
                }
            }
        }
    };
    this.showReservationList = function () {
        return this.persistedSelections.length > 0;
    };
});