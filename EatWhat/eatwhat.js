$(function () {
    optionModule.genSelectOptions();

    $('#add-item-btn').click(function () {
        $item = $('.add-item-input').val();
        if ($item) {
            optionModule.addOptionLabel($item);
        }
    })

    $('.item-container').on('click', '.item-tag-btn', function () {
        $(this).parent('label').remove();
    })

    $('#radom').click(function () {
        $itemButtons = $('.item-tag-btn');
        $itemArray = $.map($itemButtons, function (item, index) {
            return item.innerText;
        })
        $result = getResult($itemArray);
        $('#result').val($result);
    })

    $('#selectItems').change(function () {
        $selectedKey = $(this).val();
        if ($selectedKey) {
            optionModule.printItems($selectedKey);
        }
    })
    //產生min到max之間的亂數
    function getRandom(min, max) {
        // Math.random() => 隨機產生0~1之間的小數 可以想成係數
        // Math.floor() => 最大整數 5.6=>5  -5.6 =>-6
        // ref: https://ithelp.ithome.com.tw/articles/10197904
        // Math.floor(Math.random() * (max - min + 1))
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }

    function getResult(array) {
        $max = array.length - 1;
        $randomIndex = getRandom(0, $max);
        return array[$randomIndex];
    }


})
var optionModule = {
    // 定義有哪些項目
    keyToItems: {
        "攏來": [],
        "方圓無理": ["小珍園", "一騎", "豬腳", "福勝亭", "意麵盒子"],
        "要走一下子": ["最遠餛飩麵", "阿珍", "羊肉","童"],
        "速食": ["漢堡王", "MOS", "麥當勞", "頂呱呱"],
        "晴光市場": ["米粉湯", "越南", "山東水餃大王", "95牛肉麵", "鵝肉"]
    },
    /**取得所有設定的Key */
    getKeys: function () {
        return Object.getOwnPropertyNames(this.keyToItems);
    },
    /**
     * 依傳入的Key找出對應的項目(Array)
     * @param {string} key string
     */
    getItems: function (key) {
        return this.keyToItems[key];;
    },
    genSelectOptions: function () {
        $wholeKeys = this.getKeys();
        for (var i = 0; i < $wholeKeys.length; i++) {
            $('<option></option>').text($wholeKeys[i])
                .val($wholeKeys[i])
                .appendTo($('#selectItems'));
        }
    },
    printItems: function (key) {
        var $options = [];
        if (key == "攏來") {
            $wholeKeys = this.getKeys();
            for (var i = 0; i < $wholeKeys.length; i++) {
                var s = this.getItems($wholeKeys[i]);
                $options = $options.concat(s);
            }
        }
        else {
            $options = this.getItems(key);
        }
        for (var i = 0; i < $options.length; i++) {
            this.addOptionLabel($options[i]);
        }
    },
    addOptionLabel: function (optionString) {
        $label = $('<label></label>').addClass('item-tag');
        $('<button></button>').attr('type', 'button')
            .addClass('btn btn-light item-tag-btn')
            .text(optionString)
            .appendTo($label);
        $label.appendTo($('.item-container'));
    }
};